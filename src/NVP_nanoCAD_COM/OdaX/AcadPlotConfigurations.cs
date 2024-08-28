﻿using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a collection of named plot settings
///</summary>
namespace NVP_nanoCAD_COM._OdaX.AcadPlotConfigurations 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadPlotConfigurations_Constructor : INode 
	{
		public OdaX.IAcadPlotConfigurations _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadPlotConfigurations;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadPlotConfigurations_ConstructorCast : INode 
	{
		public OdaX.IAcadPlotConfigurations _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadPlotConfigurations;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Returns an object at a given index in the collection.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfigurations", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///Returns an object at a given index in the collection.
	///</summary>
	public class Item : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Item(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Returns the number of items in the collection.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfigurations", typeof(object))]

	///<summary>
	///Returns the number of items in the collection.
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
		Text = "Creates an object and adds it to the collection.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfigurations", typeof(object))]
	[NodeInput("Name", typeof(System.String))]
	[NodeInput("ModelType", typeof(System.Object))]

	///<summary>
	///Creates an object and adds it to the collection.
	///</summary>
	public class Add : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Add(inputs[1].Value,inputs[2].Value));

		}
	}

    [NVP_Manifest(
        Text = "Возвращает все Конфигурации печати в виде OdaX.AcadPlotConfiguration",
        ViewType = "Data")]
    [NodeInput("AcadPlotConfigurations", typeof(object))]
    public class GetAll_PlotConfigurations : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            var _input0 = ((dynamic)inputs[0].Value)._i as OdaX.IAcadPlotConfigurations;
            List<_OdaX.AcadPlotConfiguration.AcadPlotConfiguration_Constructor> items = new List<_OdaX.AcadPlotConfiguration.AcadPlotConfiguration_Constructor>();
            for (int item_counter = 0; item_counter < _input0.Count; item_counter++)
            {
                _OdaX.AcadPlotConfiguration.AcadPlotConfiguration_Constructor item = new _OdaX.AcadPlotConfiguration.AcadPlotConfiguration_Constructor();
                item._i = _input0.Item(item_counter);
                items.Add(item);
            }
            return new NodeResult(items);

        }
    }
}
