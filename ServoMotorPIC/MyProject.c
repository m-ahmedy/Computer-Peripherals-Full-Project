#define SERVO_PIN PORTD.B0
#define SERVO_DIRECTION TRISD.B0

short zz;
unsigned char angle = 0;

void servoAngle(unsigned char angle)
{
     switch (angle)
     {
     case 0:
          SERVO_PIN = 1;
          delay_us(1000);
          SERVO_PIN = 0;
          delay_us(19000);
          break;
     case 1:
          SERVO_PIN = 1;
          delay_us(1250);
          SERVO_PIN = 0;
          delay_us(18750);
          break;
     case 2:
          SERVO_PIN = 1;
          delay_us(1500);
          SERVO_PIN = 0;
          delay_us(18500);
          break;
     case 3:
          SERVO_PIN = 1;
          delay_us(1750);
          SERVO_PIN = 0;
          delay_us(18250);
          break;
     case 4:
          SERVO_PIN = 1;
          delay_us(2000);
          SERVO_PIN = 0;
          delay_us(18000);
          break;
     }
}
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
               angle = SSPBUF;
               SSPCON.CKP = 1;

               servoAngle(angle);
          }
          else if (!SSPSTAT.D_NOT_A && SSPSTAT.R_NOT_W)
          {
               zz = SSPBUF;
               SSPSTAT.BF = 0;
               SSPBUF = angle;
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
     SERVO_DIRECTION = 0;
     I2C_Slave_Init(0x60); //Initialize as a I2C Slave with address 0x30
     while (1)
          ;
}