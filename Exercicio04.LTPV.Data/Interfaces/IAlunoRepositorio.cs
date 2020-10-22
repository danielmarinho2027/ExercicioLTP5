using Exercicio04.LTPV.Dominio.AlunosRoot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04.LTPV.Data.Interfaces
{
    public interface IAlunoRepositorio
    {
        List<Aluno> ObterTodos();
    }
}
