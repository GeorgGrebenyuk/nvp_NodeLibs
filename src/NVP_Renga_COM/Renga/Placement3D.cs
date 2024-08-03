using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.Placement3D 
{

	[NVP_Manifest(
		Id = "EDD323FA-BD80-4259-902F-99D80EF663E9", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Placement3D.Placement3D_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Placement3D", 
		NodeName = "_Placement3D_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Placement3D_Constructor : INode 
	{
		public Renga.IPlacement3D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IPlacement3D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "1BF1ABA3-CD3B-44BE-8FB5-4331749E2891", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Placement3D.Placement3D_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Placement3D", 
		NodeName = "_Placement3D_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Placement3D_ConstructorCast : INode 
	{
		public Renga.IPlacement3D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IPlacement3D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "F75E88EC-2C7D-40F6-A725-91258B8CB299", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Placement3D.Origin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Placement3D", 
		NodeName = "Origin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Placement3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Origin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Origin);

		}
	}


	[NVP_Manifest(
		Id = "60A015A3-FF01-4536-8866-549E9DE7A951", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Placement3D.AxisX", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Placement3D", 
		NodeName = "AxisX", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Placement3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class AxisX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AxisX);

		}
	}


	[NVP_Manifest(
		Id = "E8E9B687-495E-4915-A90C-47599F272AF1", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Placement3D.AxisY", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Placement3D", 
		NodeName = "AxisY", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Placement3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class AxisY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AxisY);

		}
	}


	[NVP_Manifest(
		Id = "307ADCEF-E28B-4B32-BDA3-5AAC99405596", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Placement3D.AxisZ", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Placement3D", 
		NodeName = "AxisZ", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Placement3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class AxisZ : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AxisZ);

		}
	}


	[NVP_Manifest(
		Id = "1F02E968-6FC8-4BEF-AA7B-2DD0FBC608A5", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Placement3D.IsOrthogonal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Placement3D", 
		NodeName = "IsOrthogonal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Placement3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class IsOrthogonal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsOrthogonal);

		}
	}


	[NVP_Manifest(
		Id = "7A573357-088D-433E-A7AF-A88DA0A3A8EF", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Placement3D.IsNormal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Placement3D", 
		NodeName = "IsNormal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Placement3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class IsNormal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsNormal);

		}
	}


	[NVP_Manifest(
		Id = "BC95ED24-C83F-410A-A873-4360E12C5B8A", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Placement3D.IsLeft", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Placement3D", 
		NodeName = "IsLeft", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Placement3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class IsLeft : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsLeft);

		}
	}


	[NVP_Manifest(
		Id = "B26F5392-8D24-4C58-8710-C88C48B6C905", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Placement3D.GetTransformFrom", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Placement3D", 
		NodeName = "GetTransformFrom", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Placement3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetTransformFrom : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetTransformFrom);

		}
	}


	[NVP_Manifest(
		Id = "6C3CA2B5-8734-457F-94F4-CF0191D62717", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Placement3D.GetTransformInto", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Placement3D", 
		NodeName = "GetTransformInto", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Placement3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetTransformInto : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetTransformInto);

		}
	}


	[NVP_Manifest(
		Id = "5D15D99C-A993-4010-AC49-694EF3F4BC5F", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Placement3D.Move", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Placement3D", 
		NodeName = "Move", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Placement3D", typeof(object))]
	[NodeInput("vector_", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Move : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Move(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2DBAE79C-D5E0-4419-9107-BE333F58986A", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Placement3D.Rotate", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Placement3D", 
		NodeName = "Rotate", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Placement3D", typeof(object))]
	[NodeInput("axis_", typeof(System.Object))]
	[NodeInput("angle_", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class Rotate : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Rotate(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0B14D5A4-0318-4C8E-B616-644703E0AE76", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Placement3D.Transform", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Placement3D", 
		NodeName = "Transform", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Placement3D", typeof(object))]
	[NodeInput("pTransform", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Transform : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Transform(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C7B321D0-B31C-462B-925D-F38091CD40B3", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Placement3D.GetCopy", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Placement3D", 
		NodeName = "GetCopy", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Placement3D", typeof(object))]

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
}
