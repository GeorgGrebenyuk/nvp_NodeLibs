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
		Id = "C2E5AA11-198B-47C9-A9DC-BD54859237BD", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.DrawingCollection.DrawingCollection_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.DrawingCollection", 
		NodeName = "_DrawingCollection_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "0408F29D-A96B-41E6-BB1E-184FE27BA612", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.DrawingCollection.DrawingCollection_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.DrawingCollection", 
		NodeName = "_DrawingCollection_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "DD434364-B561-4F0E-A2F4-C2FDDF64B588", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.DrawingCollection.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.DrawingCollection", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "4413452C-4EB6-4A91-B79A-9526E08A0462", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.DrawingCollection.Get", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.DrawingCollection", 
		NodeName = "Get", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
        Id = "361A4B1C-DC01-4AB2-BB64-B5AB29908B0C",
        PathAssembly = "NVP_Renga_COM.dll",
        PathExecuteClass = "Renga.DrawingCollection.GetAll_Drawings",
        CoderName = "GeorgGrebenyuk",
        Folder = "NVP_Renga_COM.Renga.DrawingCollection",
        NodeName = "GetAll_Drawings",
        NodeType = "Loaded",
        CADType = "None",
        Text = "Возвращает все объекты чертежей",
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
