using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.Placement2D 
{

	[NVP_Manifest(
		Id = "C270E655-273B-43B8-8FF1-5C74F9A01CD4", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Placement2D.Placement2D_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Placement2D", 
		NodeName = "_Placement2D_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Placement2D_Constructor : INode 
	{
		public Renga.IPlacement2D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IPlacement2D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "929C48D0-F9DA-41EF-9AE0-D900F2AEFAAF", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Placement2D.Placement2D_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Placement2D", 
		NodeName = "_Placement2D_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Placement2D_ConstructorCast : INode 
	{
		public Renga.IPlacement2D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IPlacement2D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "48DF5BCE-6506-425B-9FEE-8EC61E180AE7", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Placement2D.Origin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Placement2D", 
		NodeName = "Origin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Placement2D", typeof(object))]

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
		Id = "382C48CE-B265-4CE6-9D62-D01AAE8A9060", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Placement2D.AxisX", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Placement2D", 
		NodeName = "AxisX", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Placement2D", typeof(object))]

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
		Id = "6878C509-5265-4254-8B16-FA16C1BE23DC", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Placement2D.AxisY", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Placement2D", 
		NodeName = "AxisY", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Placement2D", typeof(object))]

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
		Id = "4A5F34A7-136E-4BC8-BD27-234C6FDC817F", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Placement2D.IsOrthogonal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Placement2D", 
		NodeName = "IsOrthogonal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Placement2D", typeof(object))]

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
		Id = "940D25DC-A402-46C6-B875-6510A0A11D0F", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Placement2D.IsNormal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Placement2D", 
		NodeName = "IsNormal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Placement2D", typeof(object))]

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
		Id = "E7394AAD-8FD9-455E-9011-F792634431F7", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Placement2D.IsLeft", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Placement2D", 
		NodeName = "IsLeft", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Placement2D", typeof(object))]

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
		Id = "633F02CE-8848-494A-AACB-F578834D31FF", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Placement2D.GetTransformFrom", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Placement2D", 
		NodeName = "GetTransformFrom", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Placement2D", typeof(object))]

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
		Id = "E8CEF034-7AB0-4D78-8DD6-D045328DFF93", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Placement2D.GetTransformInto", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Placement2D", 
		NodeName = "GetTransformInto", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Placement2D", typeof(object))]

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
		Id = "260AE5BF-F3FE-462D-9139-5E12FB4C8926", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Placement2D.GetCopy", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Placement2D", 
		NodeName = "GetCopy", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Placement2D", typeof(object))]

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
