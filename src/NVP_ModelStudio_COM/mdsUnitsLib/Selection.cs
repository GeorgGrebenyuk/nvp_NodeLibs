using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

namespace mdsUnitsLib.Selection
{
    public class Test
    {
        public dynamic _i;
    }

    [NVP_Manifest(
       Text = "Возвращает все Объекты модели ModelStudioCS в данном Блоке в виде mdsUnitsLib.Element",
       ViewType = "Data")]
    [NodeInput("AcadBlock", typeof(object))]
    public class GetAll_EntitiesMST2 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            var _input0 = ((dynamic)inputs[0].Value)._i as OdaX.IAcadBlock;
            List<mdsUnitsLib.Element.Element_Constructor> items = new List<mdsUnitsLib.Element.Element_Constructor>();
            for (int item_counter = 0; item_counter < _input0.Count; item_counter++)
            {
                var item = new Test();
                item._i = _input0.Item(item_counter);
                bool can_add = false;
                try
                {
                    var mst_elem = item._i.Element;
                    if (mst_elem != null) can_add = true;

                }
                catch { }

                if (can_add)
                {
                    mdsUnitsLib.Element.Element_Constructor elem = new Element.Element_Constructor();
                    elem._i = item._i.Element;
                    items.Add(elem);
                }
                
            }
            return new NodeResult(items);
        }
    }

    
}
