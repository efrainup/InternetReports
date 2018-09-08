using LFSO100Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace Hinojosa.Test.RepositorioDocumentos.Mocks.LFSO100
{
    public class LFDatabaseMock : Mock<ILFDatabase>
    {
        public LFDatabaseMock()
        {
            this.Setup(mock => mock.CreateSearch()).Returns(new LFSearch());

        }


        static ILFDatabase LFDatabaseMockNormal()
        {
            var lfDatabaseMock = new Mock<ILFDatabase>();

            

            //Crear un mock de LFSearch
            lfDatabaseMock.Setup(mock => mock.CreateSearch()).Returns((LFSearch)new LFSearchMock().Object);



            return lfDatabaseMock.Object;
        }
    }
}
