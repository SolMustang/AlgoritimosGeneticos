using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritimosGeneticos.Class
{
    public class Individuo
    {
        private BitArray cromossomo;
        private double fitness;                  //nota de apitidão do individuo
        private double fitnessPercent;              //apitdão para reproduzir
        private double[] faixaRoleta = { 0, 0 }; //Faixa da Pizza que é provavel que ele seja selecionado

        public Individuo()
        {
            this.cromossomo = new BitArray(Constants.sizeComossomo);

            int i;
            for (i = 0; i < cromossomo.Length; i++)
            { 
                this.cromossomo[i] = (Constants.random.NextDouble() >= 0.5f) ? true : false; //Popula o vetor com bits aleatorios
            }
        }

        public BitArray getCromossomo()
        {
            return this.cromossomo;
        }

        public void setGene(int position, bool gene)
        {
            this.cromossomo[position] = gene;
        }

        public bool getGene(int position)
        {
            return this.cromossomo[position];
        }

        public void setFitness(double fitness)
        {
            this.fitness = fitness;
        }

        public double getFitness()
        {
            return this.fitness;
        }

        public void setFitnessPercent(double fitnessPercent)
        {
            this.fitnessPercent = fitnessPercent;
        }

        public double getFitnessPerc()
        {
            return this.fitnessPercent;
        }

        public void mutarBit(int position)
        {
            if (position < cromossomo.Length)
            {
                cromossomo.Set(position, cromossomo[position] == false ? true : false);
            }
        }
    }
}
