using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a surface created by sweeping a 2D curve along a path
///</summary>
namespace OdaX.AcadSweptSurface 
{

	[NVP_Manifest(
		Id = "5370F901-360B-43A3-935C-FE4B1A01E56A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSweptSurface.AcadSweptSurface_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSweptSurface", 
		NodeName = "_AcadSweptSurface_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSweptSurface_Constructor : INode 
	{
		public OdaX.IAcadSweptSurface _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadSweptSurface;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "DC04119E-8DA7-456C-AE07-5E105E2BBD59", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSweptSurface.AcadSweptSurface_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSweptSurface", 
		NodeName = "_AcadSweptSurface_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSweptSurface_ConstructorCast : INode 
	{
		public OdaX.IAcadSweptSurface _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadSweptSurface;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "8BA0DEFE-913A-4C18-BC95-F3DAE25A765A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSweptSurface.ProfileRotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSweptSurface", 
		NodeName = "ProfileRotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the rotation of the profile used for a swept surface.", 
		ViewType = "Data")]
	[NodeInput("AcadSweptSurface", typeof(object))]

	///<summary>
	///Specifies or returns the rotation of the profile used for a swept surface.
	///</summary>
	public class ProfileRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ProfileRotation);

		}
	}


	[NVP_Manifest(
		Id = "24065063-99DF-428A-8AED-80BCBA4E0912", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSweptSurface.Set_ProfileRotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSweptSurface", 
		NodeName = "Set_ProfileRotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the rotation of the profile used for a swept surface.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSweptSurface", typeof(object))]
	[NodeInput("profileRotationAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the rotation of the profile used for a swept surface.
	///</summary>
	public class Set_ProfileRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ProfileRotation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "45120C4A-A718-4333-BB4A-28EAAFAD4C30", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSweptSurface.Bank", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSweptSurface", 
		NodeName = "Bank", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the profile of a swept surface is banked along the path.", 
		ViewType = "Data")]
	[NodeInput("AcadSweptSurface", typeof(object))]

	///<summary>
	///Specifies or returns whether the profile of a swept surface is banked along the path.
	///</summary>
	public class Bank : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Bank);

		}
	}


	[NVP_Manifest(
		Id = "BBAF0B06-FBC5-48C0-AC67-260974E4DA3F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSweptSurface.Set_Bank", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSweptSurface", 
		NodeName = "Set_Bank", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the profile of a swept surface is banked along the path.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSweptSurface", typeof(object))]
	[NodeInput("bBank", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the profile of a swept surface is banked along the path.
	///</summary>
	public class Set_Bank : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Bank = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DCBA4483-2EB3-48C9-A8E1-87ECA5CEFD4B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSweptSurface.Twist", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSweptSurface", 
		NodeName = "Twist", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the rotation value applied along the path of a swept surface.", 
		ViewType = "Data")]
	[NodeInput("AcadSweptSurface", typeof(object))]

	///<summary>
	///Specifies or returns the rotation value applied along the path of a swept surface.
	///</summary>
	public class Twist : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Twist);

		}
	}


	[NVP_Manifest(
		Id = "1BF5DACB-95E0-4A81-9B92-CC378C393985", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSweptSurface.Set_Twist", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSweptSurface", 
		NodeName = "Set_Twist", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the rotation value applied along the path of a swept surface.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSweptSurface", typeof(object))]
	[NodeInput("TwistAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the rotation value applied along the path of a swept surface.
	///</summary>
	public class Set_Twist : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Twist = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D77A618D-2DD6-4EA2-A891-239F9837D29F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSweptSurface.scale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSweptSurface", 
		NodeName = "scale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the scale factor of a swept surface.", 
		ViewType = "Data")]
	[NodeInput("AcadSweptSurface", typeof(object))]

	///<summary>
	///Specifies or returns the scale factor of a swept surface.
	///</summary>
	public class scale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.scale);

		}
	}


	[NVP_Manifest(
		Id = "B167C9EE-7738-451D-A1AE-0CFE9A1454C4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSweptSurface.Set_scale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSweptSurface", 
		NodeName = "Set_scale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the scale factor of a swept surface.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSweptSurface", typeof(object))]
	[NodeInput("scale", typeof(System.Double))]

	///<summary>
	///Specifies or returns the scale factor of a swept surface.
	///</summary>
	public class Set_scale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.scale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FB7B0287-5E82-4E33-8A8F-4E147D547708", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSweptSurface.Length", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSweptSurface", 
		NodeName = "Length", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Returns the length of the path for a swept surface.", 
		ViewType = "Data")]
	[NodeInput("AcadSweptSurface", typeof(object))]

	///<summary>
	///Not implemented. Returns the length of the path for a swept surface.
	///</summary>
	public class Length : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Length);

		}
	}
}
