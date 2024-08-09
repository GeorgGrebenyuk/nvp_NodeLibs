using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of the collection of all registered applications in the drawing
///</summary>
namespace OdaX.AcadRegisteredApplications 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadRegisteredApplications_Constructor : INode 
	{
		public OdaX.IAcadRegisteredApplications _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadRegisteredApplications;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadRegisteredApplications_ConstructorCast : INode 
	{
		public OdaX.IAcadRegisteredApplications _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadRegisteredApplications;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Returns an object at a given index in the collection.", 
		ViewType = "Data")]
	[NodeInput("AcadRegisteredApplications", typeof(object))]
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
		Text = "Returns the number of objects in the collection.", 
		ViewType = "Data")]
	[NodeInput("AcadRegisteredApplications", typeof(object))]

	///<summary>
	///Returns the number of objects in the collection.
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
	[NodeInput("AcadRegisteredApplications", typeof(object))]
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
        Text = "Возвращает все Зарегистрированные приложения в виде OdaX.AcadRegisteredApplication",
        ViewType = "Data")]
    [NodeInput("AcadRegisteredApplications", typeof(object))]
    public class GetAll_RegisteredApplications : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            var _input0 = ((dynamic)inputs[0].Value)._i as OdaX.IAcadRegisteredApplications;
            List<OdaX.AcadRegisteredApplication.AcadRegisteredApplication_Constructor> items = new List<OdaX.AcadRegisteredApplication.AcadRegisteredApplication_Constructor>();
            for (int item_counter = 0; item_counter < _input0.Count; item_counter++)
            {
                OdaX.AcadRegisteredApplication.AcadRegisteredApplication_Constructor item = new OdaX.AcadRegisteredApplication.AcadRegisteredApplication_Constructor();
                item._i = _input0.Item(item_counter);
                items.Add(item);
            }
            return new NodeResult(items);

        }
    }
}
