using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Hinojosa.RECOVFP.DataAccessLayer.Entidades.Scontrol
{
    [XmlRoot(ElementName = "VFPData")]
    public class LayoutDanfossCollection
    {
        //[XmlArray("VFPData")]
        [XmlElement( "layoutdanfossmodel")]
        public LayoutDanfossModel[] LayoutDanfossModels;

        
    }

    class LaEnumerator : IEnumerator<LayoutDanfossModel>
    {
        LayoutDanfossModel[] LayoutDanfossModels;
        int i = 0;
        public LaEnumerator(LayoutDanfossModel[] layoutDanfossModels )
        {
            LayoutDanfossModels = layoutDanfossModels;
        }


        public object Current => LayoutDanfossModels[i];

        LayoutDanfossModel IEnumerator<LayoutDanfossModel>.Current => LayoutDanfossModels[i];

        //object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {

            return ++i < LayoutDanfossModels.Length;
        }

        public void Reset()
        {
            i = 0;
        }
    }
}
