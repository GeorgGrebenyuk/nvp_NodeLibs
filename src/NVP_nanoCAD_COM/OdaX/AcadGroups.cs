using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of the collection of all groups in the drawing
///</summary>
namespace NVP_nanoCAD_COM._OdaX.AcadGroups 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadGroups_Constructor : INode 
	{
		public OdaX.IAcadGroups _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadGroups;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadGroups_ConstructorCast : INode 
	{
		public OdaX.IAcadGroups _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadGroups;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Returns an object at a given index in the collection.", 
		ViewType = "Data")]
	[NodeInput("AcadGroups", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///Returns an object at a given index in the collection.
	///</summary>
	public class Item : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Item(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Returns the number of items in the collection.", 
		ViewType = "Data")]
	[NodeInput("AcadGroups", typeof(object))]

	///<summary>
	///Returns the number of items in the collection.
	///</summary>
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}


	[NVP_Manifest(
		Text = "Creates an object and adds it to the collection.", 
		ViewType = "Data")]
	[NodeInput("AcadGroups", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Creates an object and adds it to the collection.
	///</summary>
	public class Add : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Add(inputs[1].Value));

		}
	}

    [NVP_Manifest(
        Text = "Возвращает все Группы в виде OdaX.AcadHyperlink",
        ViewType = "Data")]
    [NodeInput("AcadHyperlinks", typeof(object))]
    public class GetAll_Groups : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            var _input0 = ((dynamic)inputs[0].Value)._i as OdaX.IAcadGroups;
            List<_OdaX.AcadGroup.AcadGroup_Constructor> items = new List<_OdaX.AcadGroup.AcadGroup_Constructor>();
            for (int item_counter = 0; item_counter < _input0.Count; item_counter++)
            {
                _OdaX.AcadGroup.AcadGroup_Constructor item = new _OdaX.AcadGroup.AcadGroup_Constructor();
                item._i = _input0.Item(item_counter);
                items.Add(item);
            }
            return new NodeResult(items);

        }
    }
}
