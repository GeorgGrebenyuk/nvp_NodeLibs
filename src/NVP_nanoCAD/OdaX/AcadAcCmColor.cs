using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///An interface for a TeighaX true color object
///</summary>
namespace OdaX.AcadAcCmColor 
{

	[NVP_Manifest(
		Id = "DE8335C8-18D7-47C1-9929-C7D848AE4842", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAcCmColor.AcadAcCmColor_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAcCmColor", 
		NodeName = "_AcadAcCmColor_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadAcCmColor_Constructor : INode 
	{
		public OdaX.IAcadAcCmColor _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadAcCmColor;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "10651ADE-0F1B-4B12-BB9B-3E833D29F5C2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAcCmColor.AcadAcCmColor_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAcCmColor", 
		NodeName = "_AcadAcCmColor_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadAcCmColor_ConstructorCast : INode 
	{
		public OdaX.IAcadAcCmColor _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadAcCmColor;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "B415AB08-A025-4D8A-AD34-661AF203D336", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAcCmColor.Set_EntityColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAcCmColor", 
		NodeName = "Set_EntityColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the AcCmEntityColor of a true color.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAcCmColor", typeof(object))]
	[NodeInput("eColor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the AcCmEntityColor of a true color.
	///</summary>
	public class Set_EntityColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EntityColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "EA44C78E-4439-44ED-B623-0889218992CF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAcCmColor.EntityColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAcCmColor", 
		NodeName = "EntityColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the AcCmEntityColor of a true color.", 
		ViewType = "Data")]
	[NodeInput("AcadAcCmColor", typeof(object))]

	///<summary>
	///Specifies or returns the AcCmEntityColor of a true color.
	///</summary>
	public class EntityColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EntityColor);

		}
	}


	[NVP_Manifest(
		Id = "13DB8ED5-28C5-459B-AAAB-F97635E0F08E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAcCmColor.ColorName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAcCmColor", 
		NodeName = "ColorName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the name of a color.", 
		ViewType = "Data")]
	[NodeInput("AcadAcCmColor", typeof(object))]

	///<summary>
	///Returns the name of a color.
	///</summary>
	public class ColorName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ColorName);

		}
	}


	[NVP_Manifest(
		Id = "210D2252-1904-4205-A7C9-80C5022D29F4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAcCmColor.BookName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAcCmColor", 
		NodeName = "BookName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the book name of a color.", 
		ViewType = "Data")]
	[NodeInput("AcadAcCmColor", typeof(object))]

	///<summary>
	///Returns the book name of a color.
	///</summary>
	public class BookName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BookName);

		}
	}


	[NVP_Manifest(
		Id = "A92D2028-154A-4D67-A55C-E93519787FBE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAcCmColor.SetNames", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAcCmColor", 
		NodeName = "SetNames", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the color name and book name of a color.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAcCmColor", typeof(object))]
	[NodeInput("ColorName", typeof(System.String))]
	[NodeInput("BookName", typeof(System.String))]

	///<summary>
	///Specifies the color name and book name of a color.
	///</summary>
	public class SetNames : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetNames(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4E5A936F-9AC3-4531-A260-DDD236DBA810", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAcCmColor.Delete", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAcCmColor", 
		NodeName = "Delete", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Deletes a true color.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAcCmColor", typeof(object))]

	///<summary>
	///Deletes a true color.
	///</summary>
	public class Delete : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Delete();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "67D9BBB1-641C-44DA-9073-EACFB565FE12", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAcCmColor.Red", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAcCmColor", 
		NodeName = "Red", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the red component of a true color.", 
		ViewType = "Data")]
	[NodeInput("AcadAcCmColor", typeof(object))]

	///<summary>
	///Returns the red component of a true color.
	///</summary>
	public class Red : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Red);

		}
	}


	[NVP_Manifest(
		Id = "990A62F7-54AD-48D7-9D3B-49B7BCFD6DC5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAcCmColor.Blue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAcCmColor", 
		NodeName = "Blue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the blue component of a true color.", 
		ViewType = "Data")]
	[NodeInput("AcadAcCmColor", typeof(object))]

	///<summary>
	///Returns the blue component of a true color.
	///</summary>
	public class Blue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Blue);

		}
	}


	[NVP_Manifest(
		Id = "EDC614B7-E7C9-4025-B415-1A13F1FBF3D8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAcCmColor.Green", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAcCmColor", 
		NodeName = "Green", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the green component of a true color.", 
		ViewType = "Data")]
	[NodeInput("AcadAcCmColor", typeof(object))]

	///<summary>
	///Returns the green component of a true color.
	///</summary>
	public class Green : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Green);

		}
	}


	[NVP_Manifest(
		Id = "12897A02-6D71-4C4C-BC90-02DBFA7A90B0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAcCmColor.SetRGB", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAcCmColor", 
		NodeName = "SetRGB", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the RGB values of a true color.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAcCmColor", typeof(object))]
	[NodeInput("Red", typeof(System.Object))]
	[NodeInput("Green", typeof(System.Object))]
	[NodeInput("Blue", typeof(System.Object))]

	///<summary>
	///Specifies the RGB values of a true color.
	///</summary>
	public class SetRGB : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetRGB(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "CA7107BB-B457-4435-8591-610CC2A55DA3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAcCmColor.Set_ColorMethod", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAcCmColor", 
		NodeName = "Set_ColorMethod", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the color method.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAcCmColor", typeof(object))]
	[NodeInput("OdaX.AcColorMethod", typeof(System.Object))]

	///<summary>
	///Specifies or returns the color method.
	///</summary>
	public class Set_ColorMethod : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ColorMethod = ((OdaX.AcColorMethod)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "450795D1-B2CD-4391-8B46-DC25411DABA9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAcCmColor.ColorMethod", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAcCmColor", 
		NodeName = "ColorMethod", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the color method.", 
		ViewType = "Data")]
	[NodeInput("AcadAcCmColor", typeof(object))]

	///<summary>
	///Specifies or returns the color method.
	///</summary>
	public class ColorMethod : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ColorMethod);

		}
	}


	[NVP_Manifest(
		Id = "A9B62E3B-5144-4700-9A12-B0C2125B6EE0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAcCmColor.ColorIndex", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAcCmColor", 
		NodeName = "ColorIndex", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the color index of an object.", 
		ViewType = "Data")]
	[NodeInput("AcadAcCmColor", typeof(object))]

	///<summary>
	///Specifies or returns the color index of an object.
	///</summary>
	public class ColorIndex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ColorIndex);

		}
	}


	[NVP_Manifest(
		Id = "439EBB97-E40E-46A9-94C6-395A36465C85", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAcCmColor.Set_ColorIndex", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAcCmColor", 
		NodeName = "Set_ColorIndex", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the color index of an object.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAcCmColor", typeof(object))]
	[NodeInput("OdaX.AcColor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the color index of an object.
	///</summary>
	public class Set_ColorIndex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ColorIndex = ((OdaX.AcColor)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3C33F885-ECB8-43EA-9383-B7C633E8DD36", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAcCmColor.SetColorBookColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAcCmColor", 
		NodeName = "SetColorBookColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the color to a color from a color book.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAcCmColor", typeof(object))]
	[NodeInput("BookName", typeof(System.String))]
	[NodeInput("ColorName", typeof(System.String))]

	///<summary>
	///Sets the color to a color from a color book.
	///</summary>
	public class SetColorBookColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetColorBookColor(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}
}
