using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Set of SymToleranceParameter values
///</summary>
namespace McCOM2.ToleranceParameters 
{

	[NVP_Manifest(
		Id = "30E06150-2697-4E90-8E51-DF6ACDFADB11", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceParameters.ToleranceParameters_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceParameters", 
		NodeName = "_ToleranceParameters_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ToleranceParameters_Constructor : INode 
	{
		public McCOM2.IToleranceParameters _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.IToleranceParameters;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "546C09AD-3A22-4FEB-A11E-61CADED04F41", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceParameters.ToleranceParameters_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceParameters", 
		NodeName = "_ToleranceParameters_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ToleranceParameters_ConstructorCast : INode 
	{
		public McCOM2.IToleranceParameters _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.IToleranceParameters;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "67BD39ED-E7AE-4971-A09A-A77AB143FB6C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceParameters.Object", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceParameters", 
		NodeName = "Object", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Parameter collection's owner object", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]

	///<summary>
	///Parameter collection's owner object
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
		Id = "0D171C99-21CA-4819-9EEC-940FA23AE90F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceParameters.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceParameters", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005a4", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]

	///<summary>
	///0x000005a4
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
		Id = "19C2664F-0DF5-48DD-B1B8-21B462157169", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceParameters.Contains", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceParameters", 
		NodeName = "Contains", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005a5", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]
	[NodeInput("McCOM2.SymToleranceParameter", typeof(System.Object))]

	///<summary>
	///0x000005a5
	///</summary>
	public class Contains : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Contains(((McCOM2.SymToleranceParameter)inputs[1].Value)));

		}
	}


	[NVP_Manifest(
		Id = "26E27C16-55C7-42F0-A089-DB288F9C3B58", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceParameters.Value", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceParameters", 
		NodeName = "Value", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005a6", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]

	///<summary>
	///0x000005a6
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
		Id = "59BF4581-8337-432A-95B9-077234E8E16C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceParameters.Set_Value", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceParameters", 
		NodeName = "Set_Value", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005a6", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceParameters", typeof(object))]
	[NodeInput("pnValue", typeof(System.Object))]

	///<summary>
	///0x000005a6
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
		Id = "6C44DE71-C4A2-45F7-AD0B-F70A48EE9384", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceParameters.ParamLinear", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceParameters", 
		NodeName = "ParamLinear", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005a7", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]

	///<summary>
	///0x000005a7
	///</summary>
	public class ParamLinear : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ParamLinear);

		}
	}


	[NVP_Manifest(
		Id = "A3AB7113-36CA-420C-8DCB-891D74F0CA7E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceParameters.Set_ParamLinear", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceParameters", 
		NodeName = "Set_ParamLinear", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005a7", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceParameters", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000005a7
	///</summary>
	public class Set_ParamLinear : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ParamLinear = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "97E9043D-57EA-4E3C-89E4-9389B7C0E0A0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceParameters.ParamPlanar", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceParameters", 
		NodeName = "ParamPlanar", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005a8", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]

	///<summary>
	///0x000005a8
	///</summary>
	public class ParamPlanar : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ParamPlanar);

		}
	}


	[NVP_Manifest(
		Id = "F1EF288D-363B-4474-A836-4E057B096767", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceParameters.Set_ParamPlanar", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceParameters", 
		NodeName = "Set_ParamPlanar", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005a8", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceParameters", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000005a8
	///</summary>
	public class Set_ParamPlanar : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ParamPlanar = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6909F0BF-9636-4950-AB96-5DDA743CCF71", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceParameters.ParamRound", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceParameters", 
		NodeName = "ParamRound", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005a9", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]

	///<summary>
	///0x000005a9
	///</summary>
	public class ParamRound : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ParamRound);

		}
	}


	[NVP_Manifest(
		Id = "781B08C4-9CC0-4859-9EEC-7D22DD3B50FF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceParameters.Set_ParamRound", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceParameters", 
		NodeName = "Set_ParamRound", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005a9", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceParameters", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000005a9
	///</summary>
	public class Set_ParamRound : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ParamRound = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "091DCE74-FC9F-4B27-9D8F-D10F82FAECEE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceParameters.ParamCylindrical", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceParameters", 
		NodeName = "ParamCylindrical", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005aa", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]

	///<summary>
	///0x000005aa
	///</summary>
	public class ParamCylindrical : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ParamCylindrical);

		}
	}


	[NVP_Manifest(
		Id = "E5E87E77-3C5F-4F39-84C1-92D78DDC378F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceParameters.Set_ParamCylindrical", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceParameters", 
		NodeName = "Set_ParamCylindrical", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005aa", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceParameters", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000005aa
	///</summary>
	public class Set_ParamCylindrical : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ParamCylindrical = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "99FDA7AA-CAAB-4526-A175-CC504B5AFCDD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceParameters.ParamProfile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceParameters", 
		NodeName = "ParamProfile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005ab", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]

	///<summary>
	///0x000005ab
	///</summary>
	public class ParamProfile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ParamProfile);

		}
	}


	[NVP_Manifest(
		Id = "55408BC3-D93C-45EE-9289-8F172BC0FCB5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceParameters.Set_ParamProfile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceParameters", 
		NodeName = "Set_ParamProfile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005ab", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceParameters", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000005ab
	///</summary>
	public class Set_ParamProfile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ParamProfile = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "73F7DBBB-4451-42A7-8F15-359E51089D59", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceParameters.ParamParallel", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceParameters", 
		NodeName = "ParamParallel", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005ac", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]

	///<summary>
	///0x000005ac
	///</summary>
	public class ParamParallel : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ParamParallel);

		}
	}


	[NVP_Manifest(
		Id = "2F7DAC35-D73D-4BFF-9365-158A70400F09", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceParameters.Set_ParamParallel", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceParameters", 
		NodeName = "Set_ParamParallel", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005ac", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceParameters", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000005ac
	///</summary>
	public class Set_ParamParallel : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ParamParallel = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C177973D-A1CC-4767-997F-201A888789D6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceParameters.ParamPerpendicular", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceParameters", 
		NodeName = "ParamPerpendicular", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005ad", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]

	///<summary>
	///0x000005ad
	///</summary>
	public class ParamPerpendicular : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ParamPerpendicular);

		}
	}


	[NVP_Manifest(
		Id = "3864749B-1521-462C-94B1-B995BD83ACE9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceParameters.Set_ParamPerpendicular", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceParameters", 
		NodeName = "Set_ParamPerpendicular", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005ad", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceParameters", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000005ad
	///</summary>
	public class Set_ParamPerpendicular : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ParamPerpendicular = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4A8C1D95-B458-4A7F-AA5B-E4002966875E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceParameters.ParamTilt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceParameters", 
		NodeName = "ParamTilt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005ae", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]

	///<summary>
	///0x000005ae
	///</summary>
	public class ParamTilt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ParamTilt);

		}
	}


	[NVP_Manifest(
		Id = "BE6890D9-6E72-4C0D-8B59-0560F139EA15", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceParameters.Set_ParamTilt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceParameters", 
		NodeName = "Set_ParamTilt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005ae", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceParameters", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000005ae
	///</summary>
	public class Set_ParamTilt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ParamTilt = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D73DF09F-1D7F-4DD3-808E-953475572DC1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceParameters.ParamCoaxiality", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceParameters", 
		NodeName = "ParamCoaxiality", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005af", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]

	///<summary>
	///0x000005af
	///</summary>
	public class ParamCoaxiality : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ParamCoaxiality);

		}
	}


	[NVP_Manifest(
		Id = "36A636EB-9630-4C11-8198-682C4AC244F3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceParameters.Set_ParamCoaxiality", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceParameters", 
		NodeName = "Set_ParamCoaxiality", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005af", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceParameters", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000005af
	///</summary>
	public class Set_ParamCoaxiality : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ParamCoaxiality = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "29C77DA6-55A6-47DE-970A-C1457BE5E5AE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceParameters.ParamSymmetry", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceParameters", 
		NodeName = "ParamSymmetry", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005b0", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]

	///<summary>
	///0x000005b0
	///</summary>
	public class ParamSymmetry : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ParamSymmetry);

		}
	}


	[NVP_Manifest(
		Id = "DA271D76-D3FF-42DF-8F36-855E6AD564A0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceParameters.Set_ParamSymmetry", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceParameters", 
		NodeName = "Set_ParamSymmetry", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005b0", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceParameters", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000005b0
	///</summary>
	public class Set_ParamSymmetry : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ParamSymmetry = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C7825ECD-C5D0-4CE7-ABA2-75B3C2E950DC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceParameters.ParamPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceParameters", 
		NodeName = "ParamPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005b1", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]

	///<summary>
	///0x000005b1
	///</summary>
	public class ParamPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ParamPosition);

		}
	}


	[NVP_Manifest(
		Id = "5D0889CD-AC81-41E9-8B79-D6EEC3636B16", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceParameters.Set_ParamPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceParameters", 
		NodeName = "Set_ParamPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005b1", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceParameters", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000005b1
	///</summary>
	public class Set_ParamPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ParamPosition = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D6BFA58B-5F18-4FF2-9464-C0234C5A2F9F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceParameters.ParamCross", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceParameters", 
		NodeName = "ParamCross", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005b2", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]

	///<summary>
	///0x000005b2
	///</summary>
	public class ParamCross : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ParamCross);

		}
	}


	[NVP_Manifest(
		Id = "05F326EA-7E6E-48B6-820A-EB6BEFA04AF9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceParameters.Set_ParamCross", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceParameters", 
		NodeName = "Set_ParamCross", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005b2", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceParameters", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000005b2
	///</summary>
	public class Set_ParamCross : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ParamCross = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4CEA8767-9379-4B80-B83A-67BA5A2DAD49", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceParameters.ParamBeat", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceParameters", 
		NodeName = "ParamBeat", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005b3", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]

	///<summary>
	///0x000005b3
	///</summary>
	public class ParamBeat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ParamBeat);

		}
	}


	[NVP_Manifest(
		Id = "9DA9761F-0FED-4944-BF9E-3DC6C005B019", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceParameters.Set_ParamBeat", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceParameters", 
		NodeName = "Set_ParamBeat", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005b3", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceParameters", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000005b3
	///</summary>
	public class Set_ParamBeat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ParamBeat = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F22D0907-2301-4F5C-95FE-51AAD908CE65", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceParameters.ParamFullBeat", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceParameters", 
		NodeName = "ParamFullBeat", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005b4", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]

	///<summary>
	///0x000005b4
	///</summary>
	public class ParamFullBeat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ParamFullBeat);

		}
	}


	[NVP_Manifest(
		Id = "46AA644C-2823-4DBE-94E4-EEC26E0A70C1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceParameters.Set_ParamFullBeat", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceParameters", 
		NodeName = "Set_ParamFullBeat", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005b4", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceParameters", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000005b4
	///</summary>
	public class Set_ParamFullBeat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ParamFullBeat = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "EB89B51C-2337-479B-A1D2-D264359C2856", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceParameters.ParamFormProfile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceParameters", 
		NodeName = "ParamFormProfile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005b5", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]

	///<summary>
	///0x000005b5
	///</summary>
	public class ParamFormProfile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ParamFormProfile);

		}
	}


	[NVP_Manifest(
		Id = "CED86CD2-06C3-4CA1-B001-E4ECA1B648F5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceParameters.Set_ParamFormProfile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceParameters", 
		NodeName = "Set_ParamFormProfile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005b5", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceParameters", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000005b5
	///</summary>
	public class Set_ParamFormProfile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ParamFormProfile = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "23F84AB2-366E-4941-94CB-B10BA725DD30", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceParameters.ParamFormSurface", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceParameters", 
		NodeName = "ParamFormSurface", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005b6", 
		ViewType = "Data")]
	[NodeInput("ToleranceParameters", typeof(object))]

	///<summary>
	///0x000005b6
	///</summary>
	public class ParamFormSurface : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ParamFormSurface);

		}
	}


	[NVP_Manifest(
		Id = "FB273340-B7C7-4079-8D0E-74B5741B7037", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ToleranceParameters.Set_ParamFormSurface", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ToleranceParameters", 
		NodeName = "Set_ParamFormSurface", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005b6", 
		ViewType = "Modifier")]
	[NodeInput("ToleranceParameters", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000005b6
	///</summary>
	public class Set_ParamFormSurface : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ParamFormSurface = inputs[1].Value;
			return null;
		}
	}
}
