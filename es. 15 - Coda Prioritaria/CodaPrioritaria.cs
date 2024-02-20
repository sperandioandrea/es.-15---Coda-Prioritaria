using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es._15___Coda_Prioritaria
{
    public class CodaPrioritaria
    {
        private ArrayList lista = new ArrayList();


        //Inserimento Elemento 
        public void Aggiunta(object elemento)
        {
            if (lista.Count == 0)
            {
                lista.Add(elemento);
            }
            else
            {
                int indiceInserimento = 0;
                while (indiceInserimento < lista.Count && ((IComparable)lista[indiceInserimento]).CompareTo(elemento) < 0)
                {
                    indiceInserimento++;
                }
                lista.Insert(indiceInserimento, elemento);
            }
        }

        //Ricerca Elemento
        public bool Ricerca(object elemento)
        {
            return lista.Contains(elemento);
        }

        

    }
}
