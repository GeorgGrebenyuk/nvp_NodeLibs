using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Object property interface
///</summary>
namespace McCOM2.Property 
{

	[NVP_Manifest(
		Id = "C643C327-EFBC-4E00-B722-318392F1700C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Property.Property_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Property", 
		NodeName = "_Property_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Property_Constructor : INode 
	{
		public McCOM2.IProperty _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.IProperty;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "33F7CD55-E9B0-4018-9BB7-77D55B006CE0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Property.Property_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Property", 
		NodeName = "_Property_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Property_ConstructorCast : INode 
	{
		public McCOM2.IProperty _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.IProperty;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "32895B4F-EEEE-49D1-A62A-219BC57DA32C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Property.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Property", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000b5", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///0x000000b5
	///</summary>
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	[NVP_Manifest(
		Id = "1A414B7B-6B1B-4020-BCF1-B99276A1543B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Property.Alias", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Property", 
		NodeName = "Alias", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000ad", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///0x000000ad
	///</summary>
	public class Alias : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Alias);

		}
	}


	[NVP_Manifest(
		Id = "9596244B-5C47-4485-B3FA-B10CAB2A8269", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Property.Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Property", 
		NodeName = "Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000b8", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///0x000000b8
	///</summary>
	public class Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Type);

		}
	}


	[NVP_Manifest(
		Id = "5BC859D8-BAA9-4E61-9378-8AB287BFDA91", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Property.Description", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Property", 
		NodeName = "Description", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000b1", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///0x000000b1
	///</summary>
	public class Description : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Description);

		}
	}


	[NVP_Manifest(
		Id = "DAC576FA-1B72-4D80-B255-6170B8DF019F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Property.Category", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Property", 
		NodeName = "Category", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000b0", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///0x000000b0
	///</summary>
	public class Category : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Category);

		}
	}


	[NVP_Manifest(
		Id = "76C1AC0A-1362-4070-A02D-4F9DD54E88E2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Property.Enabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Property", 
		NodeName = "Enabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000b2", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///0x000000b2
	///</summary>
	public class Enabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Enabled);

		}
	}


	[NVP_Manifest(
		Id = "6FBEE994-91C8-4690-B497-050D1CCEDCCA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Property.Object", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Property", 
		NodeName = "Object", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000b6", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///0x000000b6
	///</summary>
	public class Object : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Object);

		}
	}


	[NVP_Manifest(
		Id = "72827255-5875-45B2-AB7D-70C8B857A602", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Property.Value", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Property", 
		NodeName = "Value", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000b9", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///0x000000b9
	///</summary>
	public class Value : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Value);

		}
	}


	[NVP_Manifest(
		Id = "A2D14DC9-8A16-4636-B1CF-2F3FEE4D8094", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Property.Set_Value", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Property", 
		NodeName = "Set_Value", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000b9", 
		ViewType = "Modifier")]
	[NodeInput("Property", typeof(object))]
	[NodeInput("pResult", typeof(System.Object))]

	///<summary>
	///0x000000b9
	///</summary>
	public class Set_Value : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Value = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "AE5A1807-B970-4B88-AFAB-B037D4C26A30", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Property.Bounds", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Property", 
		NodeName = "Bounds", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000af", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///0x000000af
	///</summary>
	public class Bounds : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Bounds);

		}
	}


	[NVP_Manifest(
		Id = "8FD787F4-DCA8-4B88-93A7-7584314D0401", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Property.Raw", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Property", 
		NodeName = "Raw", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000b7", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///0x000000b7
	///</summary>
	public class Raw : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Raw);

		}
	}


	[NVP_Manifest(
		Id = "090B642F-A1F9-4D98-8C3D-8D13520F23F7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Property.Items", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Property", 
		NodeName = "Items", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000b4", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///0x000000b4
	///</summary>
	public class Items : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Items);

		}
	}


	[NVP_Manifest(
		Id = "38CB8C65-94CA-4512-96F0-7FBD8167C6B0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Property.Global", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Property", 
		NodeName = "Global", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000b3", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///0x000000b3
	///</summary>
	public class Global : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Global);

		}
	}


	[NVP_Manifest(
		Id = "C1AF18AF-C282-4956-B5AB-E4FED96718B9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Property.Binded", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Property", 
		NodeName = "Binded", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000ae", 
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///0x000000ae
	///</summary>
	public class Binded : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Binded);

		}
	}


	[NVP_Manifest(
		Id = "C5535663-04BF-4854-A863-2CED52584168", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Property.Set_Binded", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Property", 
		NodeName = "Set_Binded", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000ae", 
		ViewType = "Modifier")]
	[NodeInput("Property", typeof(object))]
	[NodeInput("pvbResult", typeof(System.Object))]

	///<summary>
	///0x000000ae
	///</summary>
	public class Set_Binded : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Binded = inputs[1].Value;
			return null;
		}
	}
}
