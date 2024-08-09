using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;
using Renga.Drawing;

///<summary>
///
///</summary>
namespace Renga.DrawingCollection 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class DrawingCollection_Constructor : INode 
	{
		public Renga.IDrawingCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IDrawingCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class DrawingCollection_ConstructorCast : INode 
	{
		public Renga.IDrawingCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IDrawingCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("DrawingCollection", typeof(object))]

	///<summary>
	///
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
		ViewType = "Data")]
	[NodeInput("DrawingCollection", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class Get : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Get(inputs[1].Value));

		}
	}

    [NVP_Manifest(
        Text = "Возвращает все объекты чертежей в виде Renga.Drawing",
        ViewType = "Data")]
    [NodeInput("DrawingCollection", typeof(object))]

    ///<summary>
    ///
    ///</summary>
    public class GetAll_Drawings : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            var _input0 = ((dynamic)inputs[0].Value)._i as Renga.IDrawingCollection;
			List<Drawing_Constructor> items = new List<Drawing_Constructor>();
			for (int item_counter = 0; item_counter < _input0.Count; item_counter++)
			{
                Drawing_Constructor item = new Drawing_Constructor();
                item._i = _input0.Get(item_counter);
                items.Add(item);
            }
            return new NodeResult(items);

        }
    }
}
