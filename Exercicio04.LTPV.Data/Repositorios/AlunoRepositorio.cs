using Exercicio04.LTPV.Data.Interfaces;
using Exercicio04.LTPV.Dominio.AlunosRoot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04.LTPV.Data.Repositorios
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        private List<Aluno> _alunos;

        public AlunoRepositorio()
        {
            _alunos = new List<Aluno>();

            _alunos.Add(new Aluno()
            {
                Id = 1,
                Nome = "Daniel",
                Sobrenome = "Marinho",
                DataNascimento = new DateTime(1999, 04, 22),
                Matricula = "000010"

            }) ;
            _alunos.Add(new Aluno()
            {
                Id = 2,
                Nome = "Eduardo",
                Sobrenome = "Dias",
                DataNascimento = new DateTime(198, 10, 22),
                Matricula = "0000200"

            });
            _alunos.Add(new Aluno()
            {
                Id = 3,
                Nome = "Lucas",
                Sobrenome = "Alves",
                DataNascimento = new DateTime(1999, 04, 22),
                Matricula = "0003230"

            });
            _alunos.Add(new Aluno()
            {
                Id = 4,
                Nome = "Izaquiel",
                Sobrenome = "Brito",
                DataNascimento = new DateTime(1999, 04, 22),
                Matricula = "00233010"

            });
            _alunos.Add(new Aluno()
            {
                Id = 5,
                Nome = "Diego",
                Sobrenome = "Wanderley",
                DataNascimento = new DateTime(2005, 01, 01),
                Matricula = "00012340"

            });
            _alunos.Add(new Aluno()
            {
                Id = 6,
                Nome = "Matheus",
                Sobrenome = "Galo",
                DataNascimento = new DateTime(2005, 01, 01),
                Matricula = "123456"

            });

        }
        public List<Aluno> ObterTodos()
        {
            return _alunos;
        }
    }
}
