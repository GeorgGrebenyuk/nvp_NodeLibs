using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.Curve2D 
{

	[NVP_Manifest(
		Id = "BD09201B-99FD-4C35-8491-42D4D44E9DD7", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Curve2D.Curve2D_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Curve2D", 
		NodeName = "_Curve2D_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Curve2D_Constructor : INode 
	{
		public Renga.ICurve2D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.ICurve2D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "FD61EAEA-F82E-427C-8BC2-8A67FCD827F6", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Curve2D.Curve2D_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Curve2D", 
		NodeName = "_Curve2D_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Curve2D_ConstructorCast : INode 
	{
		public Renga.ICurve2D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.ICurve2D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "034DE531-1748-4E84-B601-28FF57A397F0", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Curve2D.Curve2DType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Curve2D", 
		NodeName = "Curve2DType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Curve2D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Curve2DType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Curve2DType);

		}
	}


	[NVP_Manifest(
		Id = "6270BC72-F81D-43AA-9C6D-94C45B40A705", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Curve2D.GetCopy", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Curve2D", 
		NodeName = "GetCopy", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Curve2D", typeof(object))]

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
		Id = "5D861C71-FFFA-4292-B8D1-3EBBD2C9FA02", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Curve2D.GetBeginPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Curve2D", 
		NodeName = "GetBeginPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Curve2D", typeof(object))]

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
		Id = "5AE548A4-C95B-45C4-8948-B5B162D1DB95", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Curve2D.GetEndPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Curve2D", 
		NodeName = "GetEndPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Curve2D", typeof(object))]

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
		Id = "AEF99018-A2A6-4D97-9C20-A598AE4D23CD", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Curve2D.GetPointOn", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Curve2D", 
		NodeName = "GetPointOn", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Curve2D", typeof(object))]
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
		Id = "2038AC52-4AC8-4C8E-98A7-E674BF00DBFF", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Curve2D.MinParameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Curve2D", 
		NodeName = "MinParameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Curve2D", typeof(object))]

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
		Id = "FAFC1563-7786-499C-B8E9-EB5FEE2237C1", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Curve2D.MaxParameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Curve2D", 
		NodeName = "MaxParameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Curve2D", typeof(object))]

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
		Id = "56D5171E-9551-4270-A8A6-E8B3028E7452", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Curve2D.GetLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Curve2D", 
		NodeName = "GetLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Curve2D", typeof(object))]

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
		Id = "F3DE3B48-8998-4FC4-A497-24FFA1FF204C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Curve2D.GetGabarit", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Curve2D", 
		NodeName = "GetGabarit", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Curve2D", typeof(object))]
	[NodeInput("p1", typeof(System.Object))]
	[NodeInput("p2", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class GetGabarit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetGabarit(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9938C9E6-452F-4473-930F-B727EE9797B8", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Curve2D.IsClosed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Curve2D", 
		NodeName = "IsClosed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Curve2D", typeof(object))]

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
		Id = "B9F1DA8F-69AA-4B14-AF8D-9EEE54FE1F85", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Curve2D.GetParameterAtDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Curve2D", 
		NodeName = "GetParameterAtDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Curve2D", typeof(object))]
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
		Id = "09877BF3-F3EF-4C7B-8239-D56ADC3603E6", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Curve2D.GetTrimmed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Curve2D", 
		NodeName = "GetTrimmed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Curve2D", typeof(object))]
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
		Id = "36226A48-5B12-44E9-8F6A-B37C1EE81CFF", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Curve2D.PointProjection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Curve2D", 
		NodeName = "PointProjection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Curve2D", typeof(object))]
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
