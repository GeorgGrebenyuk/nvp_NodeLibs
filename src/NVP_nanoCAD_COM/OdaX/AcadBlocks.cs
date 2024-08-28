using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of the collection of all blocks in the drawing
///</summary>
namespace NVP_nanoCAD_COM._OdaX.AcadBlocks 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadBlocks_Constructor : INode 
	{
		public OdaX.IAcadBlocks _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadBlocks;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadBlocks_ConstructorCast : INode 
	{
		public OdaX.IAcadBlocks _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadBlocks;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Returns an object at a given index in a collection, block, group, or selection set.", 
		ViewType = "Data")]
	[NodeInput("AcadBlocks", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///Returns an object at a given index in a collection, block, group, or selection set.
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
		Text = "Returns the number of items in the collection, block, dictionary, group, or selection set.", 
		ViewType = "Data")]
	[NodeInput("AcadBlocks", typeof(object))]

	///<summary>
	///Returns the number of items in the collection, block, dictionary, group, or selection set.
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
		Text = "Creates an object and adds it to the collection, block, dictionary, group, or selection set.", 
		ViewType = "Data")]
	[NodeInput("AcadBlocks", typeof(object))]
	[NodeInput("InsertionPoint", typeof(System.Object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Creates an object and adds it to the collection, block, dictionary, group, or selection set.
	///</summary>
	public class Add : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Add(inputs[1].Value,inputs[2].Value));

		}
	}


    [NVP_Manifest(
        Text = "Возвращает все Блоки в виде OdaX.AcadBlock",
        ViewType = "Data")]
    [NodeInput("AcadBlocks", typeof(object))]
    public class GetAll_Blocks : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            var _input0 = ((dynamic)inputs[0].Value)._i as OdaX.IAcadBlocks;
            List<_OdaX.AcadBlock.AcadBlock_Constructor> items = new List<_OdaX.AcadBlock.AcadBlock_Constructor>();
            for (int item_counter = 0; item_counter < _input0.Count; item_counter++)
            {
                _OdaX.AcadBlock.AcadBlock_Constructor item = new AcadBlock.AcadBlock_Constructor();
                item._i = _input0.Item(item_counter);
                items.Add(item);
            }
            return new NodeResult(items);

        }
    }
}
