using LFSO100Lib;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinojosa.Test.RepositorioDocumentos.Mocks.LFSO100
{
    public class LFElectFileReadStreamMock : Mock<ILFElectFileReadStream>
    {
        public LFElectFileReadStreamMock()
        {

        }

        public static Mock<ILFElectFileReadStream> GetMockElectFileReadStream()
        {
            var mock = new LFElectFileReadStreamMock();

            mock.Setup(s => s.Export(It.IsAny<string>()));

            return mock;
        }
    }
}
