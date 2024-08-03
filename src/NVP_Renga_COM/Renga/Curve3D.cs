using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.Curve3D 
{

	[NVP_Manifest(
		Id = "2EF877DF-D26C-489E-9CF4-8E3E5687A7E3", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Curve3D.Curve3D_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Curve3D", 
		NodeName = "_Curve3D_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Curve3D_Constructor : INode 
	{
		public Renga.ICurve3D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.ICurve3D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "997F8810-266D-47BF-9EDA-F821363D8D0F", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Curve3D.Curve3D_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Curve3D", 
		NodeName = "_Curve3D_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Curve3D_ConstructorCast : INode 
	{
		public Renga.ICurve3D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.ICurve3D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "A8C78FFE-6AFC-4ADC-B562-2AA113D9D30A", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Curve3D.Curve3DType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Curve3D", 
		NodeName = "Curve3DType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Curve3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Curve3DType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Curve3DType);

		}
	}


	[NVP_Manifest(
		Id = "20C41509-7667-43B6-8F78-C2E12B2A6393", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Curve3D.GetCopy", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Curve3D", 
		NodeName = "GetCopy", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Curve3D", typeof(object))]

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
		Id = "EA2F23F3-3892-4122-8B82-24221756C237", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Curve3D.GetBeginPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Curve3D", 
		NodeName = "GetBeginPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Curve3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetBeginPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBeginPoint);

		}
	}


	[NVP_Manifest(
		Id = "3D5F12B1-9296-4DE9-AC66-470AEC720C6E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Curve3D.GetEndPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Curve3D", 
		NodeName = "GetEndPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Curve3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetEndPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetEndPoint);

		}
	}


	[NVP_Manifest(
		Id = "BC1518C3-962E-4A58-B6E8-33EE740FF83A", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Curve3D.GetPointOn", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Curve3D", 
		NodeName = "GetPointOn", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Curve3D", typeof(object))]
	[NodeInput("param", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class GetPointOn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPointOn(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "D272438B-AA20-486C-BBE4-4C0128F7E6A2", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Curve3D.MinParameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Curve3D", 
		NodeName = "MinParameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Curve3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class MinParameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MinParameter);

		}
	}


	[NVP_Manifest(
		Id = "0D9BEC7B-C53A-4B14-920B-CB6BADDBA887", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Curve3D.MaxParameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Curve3D", 
		NodeName = "MaxParameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Curve3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class MaxParameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MaxParameter);

		}
	}


	[NVP_Manifest(
		Id = "E1E31155-7D61-47E6-9B9F-33C20ED8B9D2", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Curve3D.GetLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Curve3D", 
		NodeName = "GetLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Curve3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLength);

		}
	}


	[NVP_Manifest(
		Id = "21F6C66E-3B37-4A22-8756-BCA23AC022FA", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Curve3D.GetGabarit", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Curve3D", 
		NodeName = "GetGabarit", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Curve3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetGabarit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetGabarit);

		}
	}


	[NVP_Manifest(
		Id = "A85B2B87-B754-4DDA-9A77-0373101D9BB3", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Curve3D.IsClosed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Curve3D", 
		NodeName = "IsClosed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Curve3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class IsClosed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsClosed);

		}
	}


	[NVP_Manifest(
		Id = "5A6CD6BA-52A9-4CD0-90F9-FFCEBDD08CF9", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Curve3D.GetParameterAtDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Curve3D", 
		NodeName = "GetParameterAtDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Curve3D", typeof(object))]
	[NodeInput("startT", typeof(System.Double))]
	[NodeInput("distance", typeof(System.Double))]
	[NodeInput("direction", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetParameterAtDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetParameterAtDistance(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "EFE77735-1D69-4207-9553-870FD0A20A25", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Curve3D.GetTrimmed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Curve3D", 
		NodeName = "GetTrimmed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Curve3D", typeof(object))]
	[NodeInput("t1", typeof(System.Double))]
	[NodeInput("t2", typeof(System.Double))]
	[NodeInput("sense", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetTrimmed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetTrimmed(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "6D6F2A24-D155-4B50-8E99-34712D585EAF", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Curve3D.PointProjection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Curve3D", 
		NodeName = "PointProjection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Curve3D", typeof(object))]
	[NodeInput("point", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class PointProjection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PointProjection(inputs[1].Value));

		}
	}
}
