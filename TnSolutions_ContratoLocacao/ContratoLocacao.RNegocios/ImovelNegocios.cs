using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContratoLocacao.Entidades;
using ContratoLocacao.Infra.Persistencia;

namespace ContratoLocacao.RNegocios
{
    public class ImovelNegocios
    {
        public Imovel NovoImovel(Imovel I)
        {
            try
            {

                //Verifica se a descrição do Imóvel esta em branco
                if (I.NomeImovel == null)
                {
                    throw new Exception("Ops! Preencha o campo nome do Imóvel");
                }
                else
                {
                    //Passa a data e hora para o campo DataInclusao
                    ImovelRepositorio ir = new ImovelRepositorio();
                    I.DataInclusao = DateTime.Now;

                    ir.Insert(I);
                    return I;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
