﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace IEADWebApp
{
    public partial class Index : System.Web.UI.Page

    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
         }


        protected void ConsultarMemb_Click(object sender, EventArgs e)
        {
            CodMemb.Text = "Toniel Lenk Moraes";
          /*  Response.Write(MessageBox("teste")); */
        }

        private string MessageBox(string p)
            {
 	            return "<script type='text/javascript'> alert("+" '"+ p +"'" + "); </script>";
            }


        protected void Limpar_Clik(object sender, EventArgs e)
        {
            if (CodMemb.Text != "") {
                 
                CodMemb.Text = "";
            }    
            else
            {
                Response.Write(MessageBox("A Consulta já está Limpa!")); 
            }     
        }

        protected void ListMemb(object sender, EventArgs e)
        {
            ConDados teste = new ConDados();
            DataTable membros = teste.Consulta();
            if (membros.Rows.Count > 0)
           {
                GridMemb.DataSource = membros;
                GridMemb.DataBind();
            }
           else {
                Response.Write(MessageBox("Não existem dados a serem retornados!")); 
            }

            
        
        }

        protected void NovoMemb(object sender, EventArgs e)
        {
            Response.Redirect("CadMemb.aspx");
            
        }

    }
}
