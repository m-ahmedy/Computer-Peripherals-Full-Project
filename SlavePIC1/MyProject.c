short zz;
short reading;

void interrupt()
{
  if (SSPIF_bit == 1)
  {
    SSPCON.CKP = 0;
    if ((SSPCON.SSPOV) || (SSPCON.WCOL))
    {
      zz = SSPBUF;
      SSPCON.SSPOV = 0;
      SSPCON.WCOL = 0;
      SSPCON.CKP = 1;
    }

    if (!SSPSTAT.D_NOT_A && !SSPSTAT.R_NOT_W)
    {
      zz = SSPBUF;
      while (!SSPSTAT.BF)
        ;
      PORTD = SSPBUF;
      SSPCON.CKP = 1;
    }
    else if (!SSPSTAT.D_NOT_A && SSPSTAT.R_NOT_W)
    {
      zz = SSPBUF;
      SSPSTAT.BF = 0;

      reading = adc_read(0) * 500 / 1023.0;

      SSPBUF = reading;
      SSPCON.CKP = 1;
      while (SSPSTAT.BF)
        ;
      /*
   SSPCON.CKP = 0;
   SSPSTAT.BF = 0;
   SSPBUF = reading;
   SSPCON.CKP = 1;
   while(SSPSTAT.BF);

   SSPCON.CKP = 0;
   SSPSTAT.BF = 0;
   SSPBUF = reading;
   SSPCON.CKP = 1;
   while(SSPSTAT.BF);
   */
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
  adc_init();
  ADCON1 = 0x04;

  I2C_Slave_Init(0x30); //Initialize as a I2C Slave with address 0x30
  while (1)
    ;
}