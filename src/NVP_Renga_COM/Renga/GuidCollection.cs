using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.GuidCollection 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class GuidCollection_Constructor : INode 
	{
		public Renga.IGuidCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IGuidCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class GuidCollection_ConstructorCast : INode 
	{
		public Renga.IGuidCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IGuidCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("GuidCollection", typeof(object))]

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
	[NodeInput("GuidCollection", typeof(object))]
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
		ViewType = "Data")]
	[NodeInput("GuidCollection", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetS(inputs[1].Value));

		}
	}

    [NVP_Manifest(
        Text = "Возвращает все Guid'ы",
        ViewType = "Data")]
    [NodeInput("GuidCollection", typeof(object))]

    public class GetAll_Guids : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            var _input0 = ((dynamic)inputs[0].Value)._i as Renga.IGuidCollection;
            List<Guid> items = new List<Guid>();
            for (int item_counter = 0; item_counter < _input0.Count; item_counter++)
            {
                Guid item = _input0.Get(item_counter);
                items.Add(item);
            }
            return new NodeResult(items);

        }
    }

    [NVP_Manifest(
        Text = "Возвращает все Guid'ы в виде строк",
        ViewType = "Data")]
    [NodeInput("GuidCollection", typeof(object))]

    public class GetAll_GuidsS : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            var _input0 = ((dynamic)inputs[0].Value)._i as Renga.IGuidCollection;
            List<string> items = new List<string>();
            for (int item_counter = 0; item_counter < _input0.Count; item_counter++)
            {
                string item = _input0.GetS(item_counter);
                items.Add(item);
            }
            return new NodeResult(items);

        }
    }
}
