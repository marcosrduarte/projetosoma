using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoSoma.Modelo
{
   public class Validacao
    {
       public String num1;
       public String num2;
       public Double n1;
       public Double n2;
       public String mensagem;

       public void Validar()
       {
           this.mensagem = "";
           try
           {
               this.n1 = Convert.ToDouble(this.num1);
               this.n2 = Convert.ToDouble(this.num2);
           }
           catch (FormatException e)
           {
               this.mensagem = "Erro de conversão";
           }
       }
    }
}
