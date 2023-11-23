using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_si_wow_wowo
{
    internal class Personaggio
    {
        private string nome;
        private int nVite;
        private char genere;
        private double attacco;

        public string GetNome()
        {
            return nome;
        }

        public int GetNVite()
        {
            return nVite;
        }

        public void SetNvite(int nvite)
        {
            if (nvite >= 0 && nvite <= 5)
            {
                this.nVite = nvite;
            } else
            {
                Console.WriteLine("non puoi impostare le vite in questo momento");
            }
        }

        public char GetGenere()
        {
            return genere;
        }

        public void SetAttacco(double attacco)
        {
            if (attacco >= 0.0 && attacco <= 1.0)
            {
                this.attacco = attacco;
            } else
            {
                Console.WriteLine("non puoi impostare l'attacco ora");
            }
        }

        public Personaggio(string nome, char genere)
        {
            this.nome = nome;
            this.nVite = 3;
            this.genere = genere;
            this.attacco = 0.5;
        }

        public string ToString()
        {
          return "Nome: " + this.nome + " - N.vite: " + this.nVite + " - Genere: " + this.genere + " - Attacco: " + this.attacco;
        }

        public void Attacca(Personaggio attaccato)
        {
            //attaccante è il this.personaggio
            //quello attaccato è "attaccato"
            if

        }
    }
}
