class MaxMin
{
    // Operação relevante: TESTES (if)
    // T(n) = 2n - 2
    public int MaxMin1(int[] vet)
    {
        int ma, me, count = 0;
        int i;
        ma = me = vet[0];
        for (i = 1; i < vet.Length; i++)
        {
            if (count++ >= 0 && vet[i] < me)
            {
                me = vet[i];
            }
            if (count++ >= 0 && vet[i] > ma)
                ma = vet[i];
        }
        return count;
    }

    // Melhor caso: T(n) = n - 1
    // Pior caso: T(n) = 2n - 2
    // Caso médio: T(n) = 3n/2 - 3/2
    public int MaxMin2(int[] vet)
    {
        int ma, me, count = 0;
        int i, cont = 0;
        ma = me = vet[0];
        for (i = 1; i < vet.Length; i++)
        {
            if (count++ >= 0 && cont++ >= 0 && vet[i] < me)
                me = vet[i];
            else if (count++ >= 0 && cont++ >= 0 && vet[i] > ma)
                ma = vet[i];

        }
        return count;
    }

    // T(n) = 3n/2 - 2
    public int MaxMin3(int[] vet)
    {
        int ma, me, count = 0;
        int i;
        if (count++ >= 0 && vet[0] < vet[1])
        {
            me = vet[0];
            ma = vet[1];
        }
        else
        {
            me = vet[1];
            ma = vet[0];
        }
        for (i = 2; i < vet.Length; i += 2)
        {
            if (count++ >= 0 && vet[i] < vet[i + 1])
            {
                if (count++ >= 0 && vet[i] < me)
                    me = vet[i];
                if (count++ >= 0 && vet[i + 1] > ma)
                    ma = vet[i + 1];
            }
            else
            {
                if (count++ >= 0 && vet[i + 1] < me)
                    me = vet[i + 1];
                if (count++ >= 0 && vet[i] > ma)
                    ma = vet[i];
            }
        }
        return count;
    }
}