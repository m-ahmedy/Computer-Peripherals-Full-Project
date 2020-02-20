#define DELAY 500
#define MIN_DELAY 100

#define STEPPER_PORT PORTD
#define STEPPER_DIRECTION TRISD

void stepperInit()
{
    STEPPER_DIRECTION = 0xF0;
    STEPPER_PORT = 0x00;
}

short zz;

unsigned char count = 0;
unsigned char newStep = 0;
unsigned char steps = 0;
unsigned char direction = 0;
unsigned char multiplier = 0;
unsigned char currentByte = 0;
unsigned char lastIndex = 0;

void fullStepCCW(char stepIndex)
{
    switch (stepIndex)
    {
    case 0:
        STEPPER_PORT = 0b00000011;
        delay_ms(MIN_DELAY);
        break;
    case 1:
        STEPPER_PORT = 0b00000110;
        delay_ms(MIN_DELAY);
        break;
    case 2:
        STEPPER_PORT = 0b00001100;
        delay_ms(MIN_DELAY);
        break;
    case 3:
        STEPPER_PORT = 0b00001001;
        delay_ms(MIN_DELAY);
        break;
    }
}

void fullStepCW(char stepIndex)
{
    switch (stepIndex)
    {
    case 0:
        STEPPER_PORT = 0b00001100;
        delay_ms(MIN_DELAY);
        break;
    case 1:
        STEPPER_PORT = 0b00000110;
        delay_ms(MIN_DELAY);
        break;
    case 2:
        STEPPER_PORT = 0b00000011;
        delay_ms(MIN_DELAY);
        break;
    case 3:
        STEPPER_PORT = 0b00001001;
        delay_ms(MIN_DELAY);
        break;
    }
}
void fullStep(unsigned char multiplier, unsigned char steps, unsigned char direction)
{
    char i, j;
    for (i = 0; i < steps; i++)
    {
        //One Large Step
        for (j = lastIndex; j < multiplier + lastIndex; j++)
        {
            if (direction == 1)
            {
                fullStepCW(j % 4);
            }
            else if (direction == 2)
            {
                fullStepCCW(j % 4);
            }
        }
        lastIndex = j;
        delay_ms(DELAY);
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
            currentByte = SSPBUF;
            SSPCON.CKP = 1;

            count++;
            switch (count)
            {
            case 1:
                multiplier = currentByte;
                break;
            case 2:
                steps = currentByte;
                break;
            case 3:
                direction = currentByte;
                break;
            }
            if (count == 3)
            {
                newStep = 1;
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
    stepperInit();
    I2C_Slave_Init(0x70); //Initialize as a I2C Slave with address 0x30
    while (1)
    {
        if (newStep)
        {
            newStep = 0;
            fullStep(multiplier, steps, direction);
        }
    };
}