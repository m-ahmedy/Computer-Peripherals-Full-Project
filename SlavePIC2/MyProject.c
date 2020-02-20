#define DHT11_PIN PORTD.B0
#define DHT11_DIRECTION TRISD.B0

short zz;
unsigned char Check, T_byte1, T_byte2, RH_byte1, RH_byte2, Ch;
unsigned Temperature, RelativeHumidity, Sum;
unsigned count = 0;

void startSignal()
{
    DHT11_DIRECTION = 0;
    DHT11_PIN = 0;
    delay_ms(18);
    DHT11_PIN = 1;
    delay_us(30);
    DHT11_DIRECTION = 1;
}

void checkResponse()
{
    Check = 0;
    delay_us(40);
    if (DHT11_PIN == 0)
    {
        delay_us(80);
        if (DHT11_PIN == 1)
            Check = 1;
        delay_us(40);
    }
}

char readData()
{
    char i, j;
    for (j = 0; j < 8; j++)
    {
        while (!DHT11_PIN)
            ;
        delay_us(30);
        if (DHT11_PIN == 0)
            i &= ~(1 << (7 - j));
        else
        {
            i |= (1 << (7 - j));
            while (DHT11_PIN)
                ;
        }
    }
    return i;
}

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

            if (count == 0)
            {
                StartSignal();
                CheckResponse();
                if (Check == 1)
                {
                    RH_byte1 = ReadData();
                    RH_byte2 = ReadData();
                    T_byte1 = ReadData();
                    T_byte2 = ReadData();
                    Sum = ReadData();
                    if (Sum == ((RH_byte1 + RH_byte2 + T_byte1 + T_byte2) & 0XFF))
                    {
                        Temperature = T_byte1;
                        RelativeHumidity = RH_byte1;
                    }
                    else
                    {
                        Temperature = 0;
                        RelativeHumidity = 0;
                    }
                }
                else
                {
                    Temperature = 0;
                    RelativeHumidity = 0;
                }
                count++;

                SSPBUF = RelativeHumidity;
                SSPCON.CKP = 1;
                while (SSPSTAT.BF)
                    ;
            }
            else
            {

                SSPBUF = Temperature;
                SSPCON.CKP = 1;
                while (SSPSTAT.BF)
                    ;
                count = 0;
            }
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
    ADCON1 = 0x07;

    I2C_Slave_Init(0x40); //Initialize as a I2C Slave with address 0x30
    while (1)
        ;
}