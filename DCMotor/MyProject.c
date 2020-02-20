#define PWM_FREQ 1000
#define DCMOTOR_POWER PORTC.B2
#define DCMOTOR_POWER_TRIS TRISC.B2

#define DCMOTOR_DIRECTION1 PORTC.B0
#define DCMOTOR_DIRECTION1_TRIS TRISC.B0
#define DCMOTOR_DIRECTION2 PORTC.B1
#define DCMOTOR_DIRECTION2_TRIS TRISC.B1

void DCMotorInit()
{
   PWM1_Init(PWM_FREQ);
   DCMOTOR_POWER_TRIS = 0;
   DCMOTOR_POWER = 0;
   DCMOTOR_DIRECTION1_TRIS = 0;
   DCMOTOR_DIRECTION1 = 0;
   DCMOTOR_DIRECTION2_TRIS = 0;
   DCMOTOR_DIRECTION2 = 0;
}

short zz;
unsigned char power = 0;
unsigned char count = 0;
//unsigned short lastByte = 0;
unsigned short currentByte = 0;

void interrupt()
{
   if (SSPIF_bit == 1)
   {
      SSPCON.CKP = 0;

      if ((SSPCON.SSPOV) || (SSPCON.WCOL))
      {
         zz = SSPBUF;      // Read the previous value to clear the buffer
         SSPCON.SSPOV = 0; // Clear the overflow flag
         SSPCON.WCOL = 0;  // Clear the collision bit
         SSPCON.CKP = 1;
      }

      if (!SSPSTAT.D_NOT_A && !SSPSTAT.R_NOT_W)
      {
         zz = SSPBUF;
         while (!SSPSTAT.BF)
            ;
         currentByte = SSPBUF;
         SSPCON.CKP = 1;

         count++;
         switch (count)
         {
         case 1:
            power = (unsigned char)currentByte;
            break;
         case 2:
            if (currentByte == 1)
            {
               DCMOTOR_DIRECTION1 = 1;
               DCMOTOR_DIRECTION2 = 0;
            }
            else if (currentByte == 2)
            {
               DCMOTOR_DIRECTION1 = 0;
               DCMOTOR_DIRECTION2 = 1;
            }

            break;
         }
         if (count == 2)
         {
            count = 0;
         }
      }
      else if (!SSPSTAT.D_NOT_A && SSPSTAT.R_NOT_W)
      {
         zz = SSPBUF;
         SSPSTAT.BF = 0;
         SSPBUF = currentByte;
         SSPCON.CKP = 1;
         while (SSPSTAT.BF)
            ;
      }

      SSPIF_bit = 0;
   }
}

void I2C_Slave_Init(short address)
{
   SSPSTAT = 0x80;
   SSPADD = address;
   SSPCON = 0x36;
   SSPCON2 = 0x01;
   TRISC.B3 = 1;
   TRISC.B4 = 1;
   GIE_bit = 1;
   PEIE_bit = 1;
   SSPIF_bit = 0;
   SSPIE_bit = 1;
}

void main()
{
   DCMotorInit();
   pwm1_start();
   I2C_Slave_Init(0x80); //Initialize as a I2C Slave with address 0x80
   while (1)
   {
      pwm1_set_duty(power);
   }
}