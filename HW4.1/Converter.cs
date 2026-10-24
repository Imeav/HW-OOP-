using System;
using System.Collections.Generic;
using System.Text;


public class Converter
{
    private decimal usd;
    private decimal eur;


    public Converter(decimal usd, decimal eur)
    {
        this.usd = usd;
        this.eur = eur;
    }

    public decimal UahToUsd(decimal amount)
    {
        return amount / usd;
    }

  
    public decimal UsdToUah(decimal amount)
    {
        return amount * usd;
    }

 
    public decimal UahToEur(decimal amount)
    {
        return amount / eur;
    }

    public decimal EurToUah(decimal amount)
    {
        return amount * eur;
    }
}

