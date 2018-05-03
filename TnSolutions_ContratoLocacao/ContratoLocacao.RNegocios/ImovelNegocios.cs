using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContratoLocacao.Entidades;
using ContratoLocacao.Infra.Persistencia;
using System.Web.Mvc;

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
                    I.Ativo = true;
                    I.DataInclusao = DateTime.Now;
                    I.DataAlteracao = null;
                    
                    ir.Insert(I);
                    return I;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }


        //Lista todas as Cidades
        public List<Imovel> TodosImoveis()
        {
            try
            {
                ImovelRepositorio ir = new ImovelRepositorio();

                List<Imovel> i = ir.Todos();
                if (i == null)
                {
                    throw new Exception("Nenhum Imóvel Selecionado");
                }
                return i;
            }
            catch (Exception e)
            {

                throw e;
            }
        }



        public SelectList ListaTodosImoveisDropDownList()
        {
            try
            {
                List<Imovel> tmp = this.TodosImoveis();
                var itens = new List<SelectListItem>();

                foreach (Imovel  i in tmp)
                {
                    itens.Add(new SelectListItem { Value = i.IdImovel.ToString(), Text = i.NomeImovel });
                }

                SelectList sli = new SelectList(itens, "Value", "Text");
                return sli;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
