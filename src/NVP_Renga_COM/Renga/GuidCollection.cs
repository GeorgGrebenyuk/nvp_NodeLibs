using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.GuidCollection 
{

	[NVP_Manifest(
		Id = "C663E0A6-C1D9-4CC7-868E-58A2BC4C73FE", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.GuidCollection.GuidCollection_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.GuidCollection", 
		NodeName = "_GuidCollection_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class GuidCollection_Constructor : INode 
	{
		public Renga.IGuidCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IGuidCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "4C3FD7A2-F658-4519-BF08-B72B01166F5C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.GuidCollection.GuidCollection_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.GuidCollection", 
		NodeName = "_GuidCollection_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class GuidCollection_ConstructorCast : INode 
	{
		public Renga.IGuidCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IGuidCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "765FD0A0-4F8F-4252-9D7C-7346485B7698", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.GuidCollection.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.GuidCollection", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("GuidCollection", typeof(object))]

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
		Id = "C064DBAF-90BD-43CB-8D7E-78C93964D128", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.GuidCollection.Get", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.GuidCollection", 
		NodeName = "Get", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("GuidCollection", typeof(object))]
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
		Id = "64BB8E87-743F-4F4D-824F-0FDCCC4C1764", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.GuidCollection.GetS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.GuidCollection", 
		NodeName = "GetS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("GuidCollection", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetS(inputs[1].Value));

		}
	}

    [NVP_Manifest(
        Id = "A5164606-1738-4BC6-A50C-A180E3381F41",
        PathAssembly = "NVP_Renga_COM.dll",
        PathExecuteClass = "Renga.GuidCollection.GetAll_Guids",
        CoderName = "GeorgGrebenyuk",
        Folder = "NVP_Renga_COM.Renga.GuidCollection",
        NodeName = "GetAll_Guids",
        NodeType = "Loaded",
        CADType = "None",
        Text = "Возвращает все Guid'ы",
        ViewType = "Data")]
    [NodeInput("GuidCollection", typeof(object))]

    public class GetAll_Guids : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            var _input0 = ((dynamic)inputs[0].Value)._i as Renga.IGuidCollection;
            List<Guid> items = new List<Guid>();
            for (int item_counter = 0; item_counter < _input0.Count; item_counter++)
            {
                Guid item = _input0.Get(item_counter);
                items.Add(item);
            }
            return new NodeResult(items);

        }
    }

    [NVP_Manifest(
        Id = "1E4110EF-CE06-4069-8582-31C70605B1E5",
        PathAssembly = "NVP_Renga_COM.dll",
        PathExecuteClass = "Renga.GuidCollection.GetAll_GuidsS",
        CoderName = "GeorgGrebenyuk",
        Folder = "NVP_Renga_COM.Renga.GuidCollection",
        NodeName = "GetAll_GuidsS",
        NodeType = "Loaded",
        CADType = "None",
        Text = "Возвращает все Guid'ы в виде строк",
        ViewType = "Data")]
    [NodeInput("GuidCollection", typeof(object))]

    public class GetAll_GuidsS : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            var _input0 = ((dynamic)inputs[0].Value)._i as Renga.IGuidCollection;
            List<string> items = new List<string>();
            for (int item_counter = 0; item_counter < _input0.Count; item_counter++)
            {
                string item = _input0.GetS(item_counter);
                items.Add(item);
            }
            return new NodeResult(items);

        }
    }
}
