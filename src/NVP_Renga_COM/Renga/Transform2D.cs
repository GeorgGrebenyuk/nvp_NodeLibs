using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.Transform2D 
{

	[NVP_Manifest(
		Id = "12726861-1437-4954-9F11-2369BA0D9C85", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Transform2D.Transform2D_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Transform2D", 
		NodeName = "_Transform2D_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Transform2D_Constructor : INode 
	{
		public Renga.ITransform2D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.ITransform2D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "359D208C-6A07-41E1-AE25-BC615A554EA3", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Transform2D.Transform2D_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Transform2D", 
		NodeName = "_Transform2D_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Transform2D_ConstructorCast : INode 
	{
		public Renga.ITransform2D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.ITransform2D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "4FB884B5-2602-4687-BB33-C30634A666E8", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Transform2D.GetElement", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Transform2D", 
		NodeName = "GetElement", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Transform2D", typeof(object))]
	[NodeInput("rowIndex", typeof(System.Int32))]
	[NodeInput("columnIndex", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetElement : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetElement(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "365200E1-E2DE-4E6F-91AB-DDF8635A35DA", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Transform2D.SetElement", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Transform2D", 
		NodeName = "SetElement", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Transform2D", typeof(object))]
	[NodeInput("rowIndex", typeof(System.Int32))]
	[NodeInput("columnIndex", typeof(System.Int32))]
	[NodeInput("value", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class SetElement : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetElement(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1AE21B4C-2CA4-42AB-8004-C5DBFD0D57B5", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Transform2D.AddTranslation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Transform2D", 
		NodeName = "AddTranslation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Transform2D", typeof(object))]
	[NodeInput("translation", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class AddTranslation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddTranslation(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7C90D1AC-F899-4BDF-BF1A-680D62D60507", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Transform2D.AddRotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Transform2D", 
		NodeName = "AddRotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Transform2D", typeof(object))]
	[NodeInput("pivot", typeof(System.Object))]
	[NodeInput("angle", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class AddRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddRotation(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DFB1DB3A-083F-4790-B879-1FF668A2B70F", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Transform2D.GetCopy", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Transform2D", 
		NodeName = "GetCopy", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Transform2D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetCopy : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCopy);

		}
	}


	[NVP_Manifest(
		Id = "681CE12B-AFE0-4948-938E-9733377FB5A8", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Transform2D.TransformPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Transform2D", 
		NodeName = "TransformPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Transform2D", typeof(object))]
	[NodeInput("pPoint", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class TransformPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TransformPoint(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "6D909766-7431-4485-85A3-9B43A083F7F3", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Transform2D.TransformVector", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Transform2D", 
		NodeName = "TransformVector", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Transform2D", typeof(object))]
	[NodeInput("pVector", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class TransformVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TransformVector(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "2BC7BB03-1360-489E-9E4F-1A7EC5DFE9FE", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Transform2D.CreateTransform3D", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Transform2D", 
		NodeName = "CreateTransform3D", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Transform2D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class CreateTransform3D : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateTransform3D);

		}
	}
}
