using LFSO100Lib;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinojosa.Test.RepositorioDocumentos.Mocks.LFSO100
{
    public class LFSearchMock : Mock<ILFSearch>
    {


        public LFSearchMock()
        {
            //Asignar los LFSearchHits por default
            List<LFSearchHit> searchHits = new List<LFSearchHit>();
            var lfDocumentMock1 = new LFDocumentMock();
            lfDocumentMock1.SetupProperty(s => s.Name,"PEDIMENTO FORMATO ANTERIOR");
            //lfDocumentMock1.SetupProperty(s => s.ElectFile, "PEDIMENTO FORMATO ANTERIOR");

            var defaultLfCollectionMock = new LFCollectionMock();
            defaultLfCollectionMock.Setup(mock => mock.GetEnumerator()).Returns(((IEnumerator<LFSearchHit>)new List<LFSearchHit>()));

            this.SetupSet(mock => mock.Command = "");


            this.Setup(mock => mock.BeginSearch(true));
            this.Setup(mock => mock.GetSearchHits()).Returns(defaultLfCollectionMock.Object);
        }
    }
}
