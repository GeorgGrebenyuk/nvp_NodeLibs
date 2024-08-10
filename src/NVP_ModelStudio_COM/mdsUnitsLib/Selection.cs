using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

namespace mdsUnitsLib.Selection
{
    [NVP_Manifest(
        Text = "Возвращает все Объекты модели ModelStudioCS в данном Блоке в виде mdsUnitsLib.MDSParametricEnt",
        ViewType = "Data")]
    [NodeInput("AcadBlock", typeof(object))]
    public class GetAll_EntitiesMST : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            var _input0 = ((dynamic)inputs[0].Value)._i as OdaX.IAcadBlock;
            List<mdsUnitsLib.MDSParametricEnt.MDSParametricEnt_Constructor> items = new List<mdsUnitsLib.MDSParametricEnt.MDSParametricEnt_Constructor>();
            for (int item_counter = 0; item_counter < _input0.Count; item_counter++)
            {
                var item = new mdsUnitsLib.MDSParametricEnt.MDSParametricEnt_Constructor();
                item._i = _input0.Item(item_counter) as mdsUnitsLib.IMDSParametricEnt;
                items.Add(item);
            }
            return new NodeResult(items);

        }
    }
}
