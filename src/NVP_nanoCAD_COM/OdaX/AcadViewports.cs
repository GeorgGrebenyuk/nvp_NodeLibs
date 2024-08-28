using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of the collection of all viewports in the drawing
///</summary>
namespace NVP_nanoCAD_COM._OdaX.AcadViewports 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadViewports_Constructor : INode 
	{
		public OdaX.IAcadViewports _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadViewports;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadViewports_ConstructorCast : INode 
	{
		public OdaX.IAcadViewports _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadViewports;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Gets the member object at a given index in a collection, group, or selection set", 
		ViewType = "Data")]
	[NodeInput("AcadViewports", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///Gets the member object at a given index in a collection, group, or selection set
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
		Text = "Gets the number of items in the collection, dictionary, group, or selection set", 
		ViewType = "Data")]
	[NodeInput("AcadViewports", typeof(object))]

	///<summary>
	///Gets the number of items in the collection, dictionary, group, or selection set
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
		Text = "Creates a member object and adds it to the appropriate collection", 
		ViewType = "Data")]
	[NodeInput("AcadViewports", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Creates a member object and adds it to the appropriate collection
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
		Text = "Deletes a viewport configuration", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewports", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Deletes a viewport configuration
	///</summary>
	public class DeleteConfiguration : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DeleteConfiguration(inputs[1].Value);
			return null;
		}
	}

    [NVP_Manifest(
        Text = "Возвращает все ВЭ чертежа в виде OdaX.AcadViewport",
        ViewType = "Data")]
    [NodeInput("AcadUCSs", typeof(object))]
    public class GetAll_Viewports : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            var _input0 = ((dynamic)inputs[0].Value)._i as OdaX.IAcadViewports;
            List<_OdaX.AcadViewport.AcadViewport_Constructor> items = new List<_OdaX.AcadViewport.AcadViewport_Constructor>();
            for (int item_counter = 0; item_counter < _input0.Count; item_counter++)
            {
                _OdaX.AcadViewport.AcadViewport_Constructor item = new _OdaX.AcadViewport.AcadViewport_Constructor();
                item._i = _input0.Item(item_counter);
                items.Add(item);
            }
            return new NodeResult(items);

        }
    }
}
