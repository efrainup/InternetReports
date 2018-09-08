using LFSO100Lib;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinojosa.Test.RepositorioDocumentos.Mocks.LFSO100
{
    public class LFElectFileMock : Mock<ILFElectFile>
    {
        public LFElectFileMock()
        {

        }

        public static Mock<ILFElectFile> GetElectFileMockWithPdf()
        {
            var mock = new LFElectFileMock();
            mock.SetupProperty(s => s.IsEmpty, false);
            mock.SetupProperty(s => s.Extension,"pdf");
            mock.SetupProperty(s => s.MimeType, "application/pdf");
            mock.SetupProperty(s => s.ReadStream, (LFElectFileReadStream)LFElectFileReadStreamMock.GetMockElectFileReadStream());
            return mock;
        }
    }
}
