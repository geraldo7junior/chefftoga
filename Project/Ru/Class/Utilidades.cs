using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RuBiz;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Ru
{
    class Utilidades
    {
        public static string DataNascCampos, CepCampos, FoneCampos, strIdCurso, strIdPeriodo, modificacao, ControleDeTela, ControleDeStatus, asterisco, NomeLogin, Cpf, CpfNovo, CpfOperador, NomeOperador, status, nome, identidade, DataNasc, rua, numero, bairro, cidade, uf, cep, fone, email, ControleDeValidaCampos="", ErrDataNasc = "" , ErrCep = "", ErrFone = "", ControleRefeicao = "", ALUNOouOPERADOR;

        public static int IdMoviment, CtrlIdMov, id, IdCard, IDCurso, IDPeriodo, TipoUser, IDOperador;

        public static float credito, debito, ValorASerCobrado, saldo;

        public static DateTime DataNascFormato;

        public static bool retorno, bolsista;

        public static void GerarPdf()
        {
            // Variavel do Nome e caminho do arquivo; Pegando DataHora Atual.
            string nome_arquivo = "";
            string DataHora = DateTime.Now.ToShortDateString().Replace("/", ".") + "_" + DateTime.Now.ToShortTimeString().Replace(":", "h");

            // Abre janela para usuário escolher a pasta onde o arquivo será gerado
            FolderBrowserDialog vSalvar = new FolderBrowserDialog();

            // Verifica se o usuário clicou em ok ou cancelar na janela de seleção da pasta
            if (vSalvar.ShowDialog() == DialogResult.Cancel) return; // Cancela todo processo

            // Insere na variavel o caminho selecionado pelo usuário e concatena com o nome do arquivo
            nome_arquivo = vSalvar.SelectedPath + "\\Relatório_" + DataHora + ".pdf";

            //Gerando arquivo...
            Document doc = new Document(iTextSharp.text.PageSize.A4.Rotate(), 3, 2, 30, 20);

            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(nome_arquivo, FileMode.Create));
            doc.Open();

            Paragraph nomeSistema = new Paragraph("CheffToga System", FontFactory.GetFont(FontFactory.TIMES_BOLDITALIC, 20));
            Paragraph titulo = new Paragraph("Relatório Geral", FontFactory.GetFont(FontFactory.TIMES_BOLD, 14));
            Paragraph datahora = new Paragraph("DataHora de Geração: " + DataHora, FontFactory.GetFont(FontFactory.TIMES, 10));
            Paragraph CardOp = new Paragraph("ID_Card: " + IDOperador.ToString(), FontFactory.GetFont(FontFactory.TIMES, 10));
            Paragraph NomeOp = new Paragraph("Operador: " + NomeOperador, FontFactory.GetFont(FontFactory.TIMES, 10));
            Paragraph pularLinha = new Paragraph(" ");

            doc.Add(nomeSistema);
            doc.Add(pularLinha);
            doc.Add(titulo);
            doc.Add(datahora);
            doc.Add(CardOp);
            doc.Add(NomeOp);
            doc.Add(pularLinha);
            doc.Add(pularLinha);

            //Gerando a Tabela de Relatório...
            PdfPTable tabela = new PdfPTable(13);
            PdfPCell celula = new PdfPCell();

            Utilidades.MontaInicioRelatorio(tabela, celula, "Id_Moviment.");
            Utilidades.MontaInicioRelatorio(tabela, celula, "Card_Operad");
            Utilidades.MontaInicioRelatorio(tabela, celula, "Cpf_Operad");
            Utilidades.MontaInicioRelatorio(tabela, celula, "Nome_Opera");
            Utilidades.MontaInicioRelatorio(tabela, celula, "Card_Aluno");
            Utilidades.MontaInicioRelatorio(tabela, celula, "Cpf_Aluno");
            Utilidades.MontaInicioRelatorio(tabela, celula, "Nome_Aluno");
            Utilidades.MontaInicioRelatorio(tabela, celula, "Data_Movmnt");
            Utilidades.MontaInicioRelatorio(tabela, celula, "Hora_Movmnt");
            Utilidades.MontaInicioRelatorio(tabela, celula, "Tipo_Movmnt");
            Utilidades.MontaInicioRelatorio(tabela, celula, "Cad_Alterad");
            Utilidades.MontaInicioRelatorio(tabela, celula, "Observacoes");
            Utilidades.MontaInicioRelatorio(tabela, celula, "Valor");

            Utilidades.GerarRelatorio(doc, tabela, celula);

            doc.Add(tabela);
            doc.Close();

            if (MessageBox.Show("Relatório Gerado com Sucesso e Salvo em " + nome_arquivo + ". Deseja Visualizá-lo?", "Relatório", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(nome_arquivo);
            }
        }

        public static void MontaInicioRelatorio(PdfPTable tabela, PdfPCell celula, string nome)
        {
            celula.Phrase = new Phrase(nome);
            celula.Phrase.Font.Size = float.Parse((7.5).ToString());
            tabela.AddCell(celula);
        }

        public static void GerarRelatorio(Document doc, PdfPTable tabela, PdfPCell celula)
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
           
                var listaMoviment = (from i in context.Movimentacao
                                where (i.Id_Movimentacao == CtrlIdMov)
                                select i.Id_Movimentacao).ToList();
                IdMoviment = listaMoviment.ToList().Count();

                if (IdMoviment != 0)
                {

                    var idmov = (from i in context.Movimentacao
                                 where i.Id_Movimentacao == CtrlIdMov
                                 select i.Id_Movimentacao).ToList();
                    string stridmov = idmov[0].ToString();

                    var idop = (from i in context.Movimentacao
                                where i.Id_Movimentacao == CtrlIdMov
                                select i.Id_Operador).ToList();
                    string stridop = idop[0].ToString();

                    var cpfop = (from i in context.Movimentacao
                                 where i.Id_Movimentacao == CtrlIdMov
                                 select i.Cpf_Operador).ToList();
                    string strcpfop = cpfop[0].ToString();

                    var nomeop = (from i in context.Movimentacao
                                  where i.Id_Movimentacao == CtrlIdMov
                                  select i.Nome_Operador).ToList();
                    string strnomeop = nomeop[0].ToString();

                    var idal = (from i in context.Movimentacao
                                where i.Id_Movimentacao == CtrlIdMov
                                select i.Id_Aluno).ToList();
                    string stridal = idal[0].ToString();

                    var cpfal = (from i in context.Movimentacao
                                 where i.Id_Movimentacao == CtrlIdMov
                                 select i.Cpf_Aluno).ToList();
                    string strcpfal = cpfal[0].ToString();

                    var nomeal = (from i in context.Movimentacao
                                  where i.Id_Movimentacao == CtrlIdMov
                                  select i.Nome_Aluno).ToList();
                    string strnomeal = nomeal[0].ToString();

                    var datamov = (from i in context.Movimentacao
                                   where i.Id_Movimentacao == CtrlIdMov
                                   select i.Data_Movimentacao).ToList();
                    string strdatamov = datamov[0].ToString();

                    var horamov = (from i in context.Movimentacao
                                   where i.Id_Movimentacao == CtrlIdMov
                                   select i.Hora_Movimentacao).ToList();
                    string strhoramov = horamov[0].ToString();

                    var tipomov = (from i in context.Movimentacao
                                   where i.Id_Movimentacao == CtrlIdMov
                                   select i.Tipo_Movimentacao).ToList();
                    string strtipomov = tipomov[0].ToString();

                    var campos = (from i in context.Movimentacao
                                  where i.Id_Movimentacao == CtrlIdMov
                                  select i.Campos).ToList();
                    string strcampos = campos[0].ToString();

                    var obs = (from i in context.Movimentacao
                               where i.Id_Movimentacao == CtrlIdMov
                               select i.Observacao).ToList();
                    string strobs = obs[0].ToString();

                    var valor = (from i in context.Movimentacao
                                 where i.Id_Movimentacao == CtrlIdMov
                                 select i.Valor).ToList();
                    string strvalor = valor[0].ToString();

                    MontaInicioRelatorio(tabela, celula, stridmov);
                    MontaInicioRelatorio(tabela, celula, stridop);
                    MontaInicioRelatorio(tabela, celula, strcpfop);
                    MontaInicioRelatorio(tabela, celula, strnomeop);
                    MontaInicioRelatorio(tabela, celula, stridal);
                    MontaInicioRelatorio(tabela, celula, strcpfal);
                    MontaInicioRelatorio(tabela, celula, strnomeal);
                    MontaInicioRelatorio(tabela, celula, strdatamov);
                    MontaInicioRelatorio(tabela, celula, strhoramov);
                    MontaInicioRelatorio(tabela, celula, strtipomov);
                    MontaInicioRelatorio(tabela, celula, strcampos);
                    MontaInicioRelatorio(tabela, celula, strobs);
                    MontaInicioRelatorio(tabela, celula, strvalor);

                    CtrlIdMov += 1;
                    GerarRelatorio(doc, tabela, celula);
                }
            }           
        }

        public static void CarregaCombobox(ComboBox cbxCurso, ComboBox cbxPeriodo)
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                //Filtro de Cursos apartir do DB:
                cbxCurso.DataSource = from i in context.Curso select i;
                cbxCurso.ValueMember = "IdCurso";
                cbxCurso.DisplayMember = "DescricaoCurso";

                //Filtro de Periodo apartir do DB:
                cbxPeriodo.DataSource = from i in context.Periodo select i;
                cbxPeriodo.ValueMember = "Id_Periodo";
                cbxPeriodo.DisplayMember = "Descricao_Periodo";

            }
        }

        public static Boolean Debitar()
        {
            if (Bolsista() == false)
            {
                using (CheffTogaEntities context = new CheffTogaEntities())
                {

                    var SaldoAtual = (from i in context.Usuario
                                      where i.CPF == Cpf
                                      select i.Saldo).ToList();

                    saldo = float.Parse(SaldoAtual[0].ToString());

                    var listid = (from i in context.Usuario
                                      where i.CPF == Cpf
                                      select i.Id_Card).ToList();

                    IdCard = listid[0];

                    var listnome = (from i in context.Usuario
                                  where i.CPF == Cpf
                                  select i.Nome).ToList();

                    string nomebolsa = listnome[0];


                    string StrResultado = Math.Round((saldo - ValorASerCobrado), 2).ToString();

                    float resultado = float.Parse(StrResultado);

                    if (ValorASerCobrado <= saldo)
                    {
                        string desconto = resultado.ToString().Replace(",", ".");

                        string strSQL = "UPDATE Usuario SET Saldo =" + desconto + " WHERE CPF='" + Cpf + "'";

                        context.ExecuteStoreCommand(strSQL);

                        var NovoSaldo = (from j in context.Usuario
                                         where j.CPF == Cpf
                                         select j.Saldo).ToList();

                        saldo = float.Parse(NovoSaldo[0].ToString());

                        Movimentacoes(IdCard, Utilidades.Cpf, nomebolsa, "Entrada de Aluno com Desconto", "-", "-", ValorASerCobrado); //registrador de movimentacões 

                        return true;
                    }

                    else return false;
                }
            }
            else
            {
                using (CheffTogaEntities context = new CheffTogaEntities())
                {
                    var listnome = (from i in context.Usuario
                                    where i.CPF == Cpf
                                    select i.Nome).ToList();

                    string nomebolsa = listnome[0];

                    if (ControleDeTela == "autorizarporcpf")
                    {
                        ALUNOouOPERADOR = "ALUNO";
                    }
                    else ALUNOouOPERADOR = "OPERADOR";


                    Movimentacoes(IdCard, Utilidades.Cpf, nomebolsa, "Entrada de " + ALUNOouOPERADOR + " BOLSISTA" , "-", "-", 0); //registrador de movimentacões 

                    MessageBox.Show("Entrada sem desconto! " + ALUNOouOPERADOR + " BOLSISTA!", "Entrada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return true;
                }
            }

        }

        public static void Creditar()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {

                var linq = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Id_Usuario).ToList();

                id = linq[0];

                var SaldoAtual = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Saldo).ToList();

                saldo = float.Parse(SaldoAtual[0].ToString());

                string StrResultado = Math.Round((saldo + credito), 2).ToString();

                float resultado = float.Parse(StrResultado);

                string strCredito = resultado.ToString().Replace(",", ".");

                string strSQL = "UPDATE Usuario SET Saldo =" + strCredito + " WHERE Id_Usuario=" + id;
                
                context.ExecuteStoreCommand(strSQL);

                var NovoSaldo = (from j in context.Usuario
                                 where j.CPF == Cpf
                                 select j.Saldo).ToList();

                saldo = float.Parse(NovoSaldo[0].ToString());

            }

        }

        public static void DebitarEstorno()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {

                var linq = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Id_Usuario).ToList();

                id = linq[0];

                var SaldoAtual = (from i in context.Usuario
                                  where i.CPF == Cpf
                                  select i.Saldo).ToList();

                saldo = float.Parse(SaldoAtual[0].ToString());

                string StrResultado = Math.Round((saldo - debito), 2).ToString();

                float resultado = float.Parse(StrResultado);

                string strDebito = resultado.ToString().Replace(",", ".");

                string strSQL = "UPDATE Usuario SET Saldo =" + strDebito + " WHERE Id_Usuario=" + id;

                context.ExecuteStoreCommand(strSQL);

                var NovoSaldo = (from j in context.Usuario
                                 where j.CPF == Cpf
                                 select j.Saldo).ToList();

                saldo = float.Parse(NovoSaldo[0].ToString());

            }

        }

        public static void Movimentacoes(int IdAluno, string CpfAluno, string NomeAluno, string TipoMovimentacao, string Campos, string Observacao, float valor)
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                Movimentacao mov = new Movimentacao();
                var linq = (from i in context.Movimentacao select i.Id_Movimentacao).Max();
                mov.Id_Movimentacao = linq + 1;
                mov.Id_Operador = IDOperador;
                mov.Cpf_Operador = CpfOperador;
                mov.Nome_Operador = NomeOperador;
                mov.Id_Aluno = IdAluno;
                mov.Cpf_Aluno = CpfAluno;
                mov.Nome_Aluno = NomeAluno;
                mov.Data_Movimentacao = DateTime.Now.ToShortDateString();
                mov.Hora_Movimentacao = DateTime.Now.ToShortTimeString();
                mov.Tipo_Movimentacao = TipoMovimentacao;
                mov.Campos = Campos;
                mov.Observacao = Observacao;
                context.AddObject("Movimentacao", mov);
                context.SaveChanges();

                string strValor = valor.ToString().Replace(",", ".");
                int locMov = linq + 1;

                string SQL = "UPDATE Movimentacao SET Valor=" + strValor + " WHERE Id_Movimentacao=" + locMov;

                context.ExecuteStoreCommand(SQL);
            }
        }

        public static Boolean VerRefeicao()
        {
            Usuario user = new Usuario();

            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var DataRef = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Data_Refeicao).ToList();
                DateTime data_refeicao = DateTime.Parse(DataRef[0].ToString());

                var VerAlmoco = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Almoco).ToList();
                bool ver_almoco = bool.Parse(VerAlmoco[0].ToString());

                var VerJantar = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Jantar).ToList();
                bool ver_jantar = bool.Parse(VerJantar[0].ToString());

                if (ControleRefeicao == "almoco")
                {
                    if ((data_refeicao.Date < DateTime.Now.Date) || (ver_almoco == false) || (data_refeicao == null))
                    {
                        retorno = false;
                    }
                    else
                    {
                        MessageBox.Show("Cartão já utilizado para Almoço!", "Não Autorizado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        retorno = true;
                    }
                }
                
                else if (ControleRefeicao == "jantar")
                {
                    if ((data_refeicao.Date < DateTime.Now.Date) || (ver_jantar == false) || (data_refeicao == null))
                    {
                        retorno = false;
                    }
                    else
                    {
                        MessageBox.Show("Cartão já utilizado para o Jantar!", "Não Autorizado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        retorno = true;
                    }
                }
            }

            return retorno;
        }

        public static Boolean VerStatus()
        {
            Usuario user = new Usuario();

            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var verstatus = (from i in context.Usuario
                               where i.CPF == Cpf
                               select i.Status).ToList();
                string status = verstatus[0];

                if (status == "Desbloqueado") return true;
                else return false;               
            }
        }

        public static void Bandeja_Espera()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                string strSQL = "UPDATE Usuario SET Bandeja_Em_Espera ='" + true + "' WHERE CPF='" + Cpf + "'";
                context.ExecuteStoreCommand(strSQL);                
            }
        }

        public static void PegarBandeja()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var listData = (from i in context.Usuario
                                where i.CPF == Cpf
                                select i.Data_Refeicao).ToList();
                DateTime dataRef = DateTime.Parse(listData[0]);

                var listBandeja = (from i in context.Usuario
                                where i.CPF == Cpf
                                select i.Bandeja_Em_Espera).ToList();
                bool bandejaEspera = bool.Parse(listBandeja[0].ToString());

                if ((dataRef.Date == DateTime.Now.Date) && (bandejaEspera == true))
                {
                    string strSQL = "UPDATE Usuario SET Bandeja_Em_Espera ='" + false + "' WHERE CPF='" + Cpf + "'";
                    context.ExecuteStoreCommand(strSQL);
                    MessageBox.Show("Autorizado!", "Bandeja", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                else MessageBox.Show("Não Autorizado! Ou já foi pego bandeja ou pagamento não efetuado", "Bandeja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ComparaAlteracao(string db, string txt, string campo)
        {
            if (db != txt) modificacao += campo + ", ";
        }

        public static void AltCampos()
        {
            modificacao = "";

            string STATUS, NOME, IDENTIDADE, CPFVELHO, RUA, N, BAIRRO, CIDADE, UF, EMAIL;
            bool BOLSISTA;
            int TIPOUSUARIO;

            STATUS = Status();
            NOME = Nome();
            IDENTIDADE = Identidade();
            // DataNasc através de DataNascCampos;
            CPFVELHO = CpF();
            BOLSISTA = Bolsista();
            // Curso através da strIdCurso
            // Periodo através de strIdPeriodo
            RUA = Rua();
            N = Numero();
            BAIRRO = Bairro();
            CIDADE = Cidade();
            UF = Uf();
            //CEP através de CepCampos;
            //Fone através de FoneCampos;
            EMAIL = Email();
            TIPOUSUARIO = TipoOperador();

            ComparaAlteracao(STATUS, status, "Status");
            ComparaAlteracao(NOME, nome.Replace("'", "''"), "Nome");
            ComparaAlteracao(IDENTIDADE, identidade, "RG");
            ComparaAlteracao(DataNascCampos, DataNasc, "Data de Nascimento");
            ComparaAlteracao(CPFVELHO, CpfNovo, "CPF");
            ComparaAlteracao(BOLSISTA.ToString(), bolsista.ToString(), "Bolsista");
            ComparaAlteracao(RUA, rua, "Rua");
            ComparaAlteracao(N, numero, "Número");
            ComparaAlteracao(BAIRRO, bairro, "Bairro");
            ComparaAlteracao(CIDADE, cidade, "Cidade");
            ComparaAlteracao(UF, uf, "UF");
            ComparaAlteracao(CepCampos, cep, "CEP");
            ComparaAlteracao(FoneCampos, fone, "Fone");
            ComparaAlteracao(EMAIL, email, "E-Mail");
            ComparaAlteracao(TIPOUSUARIO.ToString(), TipoUser.ToString(), "Tipo do Usuário");
            if (ControleDeTela != "alterarOp")
            {
                ComparaAlteracao(strIdCurso, IDCurso.ToString(), "Curso");
                ComparaAlteracao(strIdPeriodo, IDPeriodo.ToString(), "Período");
            }


        }        

        public static void AlterarDados()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var linq = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Id_Usuario).ToList();

                id = linq[0];

                string strSQL = "UPDATE Usuario SET Nome ='" + nome.Replace("'", "''") + "', Status= '" + status + "', Id_TipoUsuario= '" + TipoUser +
                                "', RG='" + identidade + "', Logradouro='" + rua + "', Numero='" + numero + "', Bairro='" + bairro + "', Cidade='" + cidade + 
                                "',CPF='" + CpfNovo + "', UF='" + uf + "', CEP='" + cep + "', Fone='" + fone + "', E_mail='" + email + "', Bolsista='" + bolsista + 
                                "', DataNascimento='" + DataNasc + "', Id_Curso=" + IDCurso + ", Id_Periodo= " + IDPeriodo + " WHERE Id_Usuario=" + id;

                context.ExecuteStoreCommand(strSQL);

                Cpf = CpfNovo;

                MessageBox.Show("Cadastro alterado com sucesso!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        public static void ModStatus(string estado, string obs)
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                string SQL = "UPDATE Usuario SET Status='" + estado + "' WHERE Id_TipoUsuario=1";
                context.ExecuteStoreCommand(SQL);
                Movimentacoes(0, "-", "-", "Status de todos os Alunos " + estado + "s" , "-", obs, 0); //registrador de movimentacões
            }

            MessageBox.Show("Operação realizada com sucesso! Todos os alunos foram " + estado + "s!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ModStatusOp(string estado, string obs)
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                string SQL = "UPDATE Usuario SET Status='" + estado + "' WHERE ((Id_TipoUsuario>1) and (Id_TipoUsuario<5))";
                context.ExecuteStoreCommand(SQL);
                Movimentacoes(0, "-", "-", "Status de todos os Operadores " + estado + "s", "-", obs, 0); //registrador de movimentacões
            }

            MessageBox.Show("Operação realizada com sucesso! Todos os Operadores foram " + estado + "s!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }         

        public static void ExcluirCadastro()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {

                var linq = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Id_Usuario).ToList();
                id = linq[0];

                var linqIdCard = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Id_Card).ToList();
                IdCard = linqIdCard[0];

                var linqnome = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Nome).ToList();
                string name = linqnome[0];

                var linqTipo = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Id_TipoUsuario).ToList();
                int TipoUser = linqTipo[0];

                if (TipoUser == 1) Utilidades.Movimentacoes(IdCard, Utilidades.Cpf, name, "Exclusão de Cadastro de Aluno", "Todos", "-", 0); //registrador de movimentacões
                else Utilidades.Movimentacoes(IdCard, Utilidades.Cpf, name, "Exclusão de Cadastro de Operador", "Todos", "-", 0); //registrador de movimentacões

                if (IdCard != IDOperador)
                {
                    string strSQLCartao = "DELETE FROM Usuario WHERE Id_Usuario=" + id + "";
                    context.ExecuteStoreCommand(strSQLCartao);
                    MessageBox.Show("Cadastro excluído com sucesso!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else MessageBox.Show("Operação não Autorizada! Usuário Conectado ao Sistema.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static Int32 GerarIdCard(int verificador)
        {
            string StrVerificador = verificador.ToString();
            string ano = DateTime.Now.Year.ToString();
            string cpf3 = Cpf.Substring(0, 3);

            IdCard = int.Parse(ano + cpf3 + StrVerificador);

            return IdCard;

        }

        public static Int32 SelecionaUsuario(bool gerente, bool cadastro, bool credito, bool entrada)
        {
            if (gerente == true) return 5;
            else if (cadastro == true) return 2;
            else if (credito == true) return 3;
            else return 4;
        }

        public static String PreencherCamposVF(bool gerente, bool cadastro, bool credito, bool entrada)
        {
            if ((gerente == false) && (cadastro == false) && (credito == false) && (entrada == false))
            {
                asterisco = "*";
            }
            else
            {
                asterisco = "";
            }

            return (asterisco);

        }

        public static String PreencherCampos(String campo)
        {
            if (campo == "")
            {
                asterisco = "*";
            }
            else
            {
                asterisco = "";
            }

            return (asterisco);

        }

        public static String Id_Card()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var item = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Id_Card).ToList();
                return item[0].ToString();
            }
        }

        public static String Status()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var item = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Status).ToList();
                return item[0];
            }
        }

        public static Int32 TipoOperador()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {

                var item = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Id_TipoUsuario).ToList();
                Int32 tipo = int.Parse(item[0].ToString());

                return tipo;
            }
        }

        public static Boolean Bolsista()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var item = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Bolsista).ToList();
                return bool.Parse(item[0].ToString());
            }
        }

        public static String Nome()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var item = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Nome).ToList();
                return item[0];
            }
        }

        public static String Email()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var item = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.E_mail).ToList();
                return item[0];
            }
        }

        public static String Identidade()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var item = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.RG).ToList();
                return item[0];
            }
        }

        public static String CpF()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var item = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.CPF).ToList();
                return item[0];
            }
        }

        public static String FuncDataNasc()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var item = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.DataNascimento).ToList();
                string DataNascSpace = item[0].Replace(" ","");
                DataNasc = DataNascSpace.Replace("/", "");
                return DataNasc;
            }
        }

        public static String Curso()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var IdCurso = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Id_Curso).ToList();
                IDCurso = int.Parse(IdCurso[0].ToString());

                var Curso = (from i in context.Curso
                             where i.IdCurso == IDCurso
                             select i.DescricaoCurso).ToList();
                string curso = Curso[0];

                strIdCurso = IDCurso.ToString(); //modificação de campos

                return curso;
            }
        }

        public static String Periodo()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var IdPeriodo = (from i in context.Usuario
                               where i.CPF == Cpf
                               select i.Id_Periodo).ToList();
                IDPeriodo = int.Parse(IdPeriodo[0].ToString());

                var Periodo = (from i in context.Periodo
                             where i.Id_Periodo == IDPeriodo
                             select i.Descricao_Periodo).ToList();
                string periodo = Periodo[0];

                strIdPeriodo = IDPeriodo.ToString(); //modificação de campos

                return periodo;
            }
        }          

        public static String Saldo()
        {            
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                Usuario card = new Usuario();

                var meusaldo = (from i in context.Usuario
                            where i.CPF == Utilidades.Cpf
                            select i.Saldo).ToList();
                
                var SALDO = meusaldo[0];

                return SALDO.ToString();
            }
        }

        public static String Rua()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var item = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Logradouro).ToList();
                return item[0];
            }
        }

        public static String Numero()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var item = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Numero).ToList();
                return item[0];
            }
        }

        public static String Bairro()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var item = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Bairro).ToList();
                return item[0];
            }
        }

        public static String Cidade()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var item = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Cidade).ToList();
                return item[0];
            }
        }

        public static String Uf()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var item = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.UF).ToList();
                return item[0];
            }
        }

        public static String Cep()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var item = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.CEP).ToList();
                string CepPonto = item[0].Replace(".", "");
                string CepDigito = CepPonto.Replace("-", "");
                cep = CepDigito.Replace(" ", "");

                return cep;
            }
        }

        public static String FuncFone()
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var item = (from i in context.Usuario
                            where i.CPF == Cpf
                            select i.Fone).ToList();
                string foneParAberto = item[0].Replace("(","");
                string foneParFechado = foneParAberto.Replace(")", "");
                string foneDigito = foneParFechado.Replace("-", "");
                fone = foneDigito.Replace(" ", "");
                
                return fone;
            }
        }

        public static void ValidaCampos()
        {
            //Controle de data de nascimento
            if (Utilidades.validaData(DataNasc) == false)
            {
                ErrDataNasc = "Data de Nascimento; ";
            }
            else
            {
                ErrDataNasc = "";
                Utilidades.DataNascFormato = DateTime.Parse(DataNasc);
            }

            if (DataNascFormato > DateTime.Now)
            {
                ErrDataNasc = "Data de Nascimento; ";
            }

            //Controle de Cep
            if (validaCEP(cep) == false)
            {
                ErrCep = "CEP ;";
            }

            //Controle de fone
            if (validaFone(fone) == false)
            {
                ErrFone = "Fone";
            }

            if ((ErrDataNasc != "") || (ErrFone != "") || (ErrCep != ""))
            {
                MessageBox.Show("O(s) Campo(s): " + ErrDataNasc + ErrCep + ErrFone + " está(ão) incorreto(s)!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ControleDeValidaCampos = "N";
            }
            
            //CADASTRO NOVO
            if (Utilidades.ControleDeTela == "novo")
            {
                //controle de cpf válido
                if (Utilidades.validaCPF(Utilidades.Cpf) == false)
                {
                    MessageBox.Show("CPF Inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ControleDeValidaCampos = "N";
                }

                //controle de cpf duplicado
                else if (Utilidades.DuploCPF(Utilidades.Cpf) == true)
                {
                    MessageBox.Show("CPF já existente na Base de Dados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ControleDeValidaCampos = "N";
                }
            }

            //ALTERAR CADASTRO
            if (Utilidades.ControleDeTela == "alterar")
            {
                //controle de cpf válido
                if (Utilidades.validaCPF(Utilidades.CpfNovo) == false)
                {
                    MessageBox.Show("CPF Inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ControleDeValidaCampos = "N";
                }

                //controle de cpf duplicado
                else if (Utilidades.DuploCPF(Utilidades.CpfNovo) == true)
                {
                    MessageBox.Show("CPF já existente na Base de Dados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ControleDeValidaCampos = "N";
                }

            }

        }

        public static Boolean validaData(String data)
        {
            DateTime result;
            if (DateTime.TryParse(data, out result))
                return true;
            else  return false;
        }

        public static Boolean validaCPF(String cpf)
        {
            int result;
            result = cpf.Length;
            if (result == 11)
                return true;
            else return false;
        }

        public static Boolean validaFone(String foneParaTeste)
        {
            fone = foneParaTeste.Replace(" ", "");
            int result;
            result = fone.Length;
            if (result == 13)
                return true;
            else return false;
        }

        public static Boolean validaCEP(String cepParaTeste)
        {
            cep = cepParaTeste.Replace(" ", "");
            int result;
            result = cep.Length;
            if (result == 10)
                return true;
            else return false;
        }

        public static Boolean DuploCPF(String cpfEnviado)
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var list = (from i in context.Usuario
                            where i.CPF == cpfEnviado
                            select cpfEnviado).ToList();

                if ((list.ToList().Count() > 0) && (Cpf != CpfNovo))
                {
                    return true;
                }

                else return false;
            }
        }

        public static Boolean ErrAluno(string cpf)
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var linq = (from i in context.Usuario
                            where i.CPF == cpf
                            select i.Id_TipoUsuario).ToList();

                if ((linq.ToList().Count() == 1) && (linq[0] != 1))
                {
                    return true;
                }
                else return false;

            }
        }

        public static Boolean ErrOperador(string cpf)
        {
            using (CheffTogaEntities context = new CheffTogaEntities())
            {
                var linq = (from i in context.Usuario
                            where i.CPF == cpf
                            select i.Id_TipoUsuario).ToList();

                if ((linq.ToList().Count() == 1) && (linq[0] == 1))
                {
                    return true;
                }
                else return false;

            }
        }
    }
}
