using System;

public class Ajanda
{
    string telEv;
    string telIş;
    string telCep1;
    string telCep2;

    public Ajanda(string telEv, string telIş, string telCep1, string telCep2)
	{
        this.telEv = telEv;
        this.telIş = telIş;
        this.telCep1 = telCep1;
        this.telCep2 = telCep2;
    }

    public Ajanda(string telEv, string telCep1)
    {
        this.telEv = telEv;
        this.telCep1 = telCep1;
    }

    public Ajanda(string telEv, string telIş, string telCep1)
    {
        this.telEv = telEv;
        this.telIş = telIş;
        this.telCep1 = telCep1;
    }

    public Ajanda(string telEv, string telCep1, string telCep2)
    {
        this.telEv = telEv;
        this.telCep1 = telCep1;
        this.telCep2 = telCep2;
    }
}
