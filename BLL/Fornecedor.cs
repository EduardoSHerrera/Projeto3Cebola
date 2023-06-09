﻿using DAL;
using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Razao { get; set; }
        public string CNPJ { get; set; }
        public string Telefone{get; set;}
        public string Email { get; set;}
        Conexao con;

        public bool Gravar()
        {
            con = new Conexao();
            string sql = $"insert into tb_fornecedor values (null, " + $"{Razao}, {CNPJ}, {Telefone}, {Email})";
            return con.Executar(sql);
        }

        public bool Atualizar()
        {
            con = new Conexao();
            string sql = $"update tb_fornecedor set forn_razao={Razao}," + $"forn_cnpj={CNPJ}, forn_telefone={Telefone}, "
                + $"forn_email={Email} where for_id={Id}";
            return con.Executar(sql);
        }

        public bool Excluir()
        {
            con = new Conexao();
            string sql = $"delete from tb_fornecedor where forn_id={Id}";
            return con.Executar(sql);
        }
         public DataTable Pesquisar()
        {
            try
            {
                con = new Conexao();
                string sql = $"select = from tb_fornecedor";
                DataTable dt = new DataTable();
                dt = con.Retorna(sql);
                return dt;
            }catch(Exception ex)
            {
                return new DataTable();
            }
        }
    }
}
