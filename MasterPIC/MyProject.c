#define _XTAL_FREQ 8000000
#define numSensors 4
#define DELAY 200

unsigned char readbuff[64] absolute 0x500;
unsigned char writebuff[64] absolute 0x540;

void I2C_Master_Init(const unsigned long c)
{
  SSPCON1 = 0b00101000;
  SSPCON2 = 0;
  SSPADD = (_XTAL_FREQ / (4 * c)) - 1;
  SSPSTAT = 0;
  TRISC.B3 = 1;
  TRISC.B4 = 1;
}

void I2C_Master_Wait()
{
  while ((SSPSTAT & 0x04) || (SSPCON2 & 0x1F))
    ;
}

void I2C_Master_Start()
{
  I2C_Master_Wait();
  SSPCON2.SEN = 1;
}

void I2C_Master_RepeatedStart()
{
  I2C_Master_Wait();
  SSPCON2.RSEN = 1;
}

void I2C_Master_Stop()
{
  I2C_Master_Wait();
  SSPCON2.PEN = 1;
}

void I2C_Master_Write(unsigned d)
{
  I2C_Master_Wait();
  SSPBUF = d;
}

unsigned short I2C_Master_Read(unsigned short a)
{
  signed short temp;
  I2C_Master_Wait();
  SSPCON2.RCEN = 1;
  I2C_Master_Wait();
  temp = SSPBUF;
  I2C_Master_Wait();
  SSPCON2.ACKDT = (a) ? 0 : 1;
  SSPCON2.ACKEN = 1;
  return temp;
}

void interrupt()
{
  USB_Interrupt_Proc();
}

void main()
{
  unsigned char i, x[6];
  unsigned char addresses[numSensors] = {0x31, 0x41, 0x51, 0x41};

  HID_Enable(&readbuff, &writebuff);
  I2C_Master_Init(100000); //Initialize I2C Master with 100KHz clock
  while (1)
  {
    while (!HID_read())
      ;

    if (memcmp(readbuff, "ga", 2) == 0)
    {
      for (i = 0; i < numSensors; i++)
      {
        I2C_Master_Start();                //Start condition
        I2C_Master_Write(addresses[i]);    //7 bit address + Read
        writebuff[i] = I2C_Master_Read(0); //Read + Acknowledge
        I2C_Master_Stop();
        delay_ms(DELAY);
      }

      while (!HID_Write(&writebuff, 64))
        ;
    }
    else if (memcmp(readbuff, "dc", 2) == 0)
    {

      x[0] = readBuff[2];
      x[1] = readBuff[3];

      for (i = 0; i < 2; i++)
      {
        I2C_Master_Start();
        I2C_Master_Write(0x80);
        I2C_Master_Write(x[i]);
        I2C_Master_Stop();
        delay_ms(DELAY);
      }
    }
    else if (memcmp(readbuff, "sm", 2) == 0)
    {
      x[0] = readBuff[2];
      I2C_Master_Start();
      I2C_Master_Write(0x60);
      I2C_Master_Write(x[0]);
      I2C_Master_Stop();
      delay_ms(DELAY);
    }
    else if (memcmp(readbuff, "st", 2) == 0)
    {
      /*x[0] = 'm';
      x[1] = readBuff[2];
      x[2] = 's';
      x[3] = readBuff[3];
      x[4] = 'd';
      x[5] = readBuff[4];
      */
      x[0] = readBuff[2];
      x[1] = readBuff[3];
      x[2] = readBuff[4];

      for (i = 0; i < 3; i++)
      {
        I2C_Master_Start();
        I2C_Master_Write(0x70);
        I2C_Master_Write(x[i]);
        I2C_Master_Stop();
        delay_ms(DELAY);
      }
    }

    delay_ms(2 * DELAY);
  }
}