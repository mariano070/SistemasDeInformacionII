gx.evt.autoSkip=false;function viewgestores(){this.ServerClass="ViewGESTORES";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=false;this.autoRefresh=true;this.SetStandaloneVars=function(){this.AV11GestorCod=gx.fn.getControlValue("vGESTORCOD");this.AV7TabCode=gx.fn.getControlValue("vTABCODE")};this.s112_client=function(){this.AV8Tabs=[];this.AV9Tab={Code:"",Description:"",Link:"",WebComponent:""};this.AV9Tab.Code="General";this.AV9Tab.Description="General";this.AV9Tab.WebComponent=gx.http.formatLink("gestoresgeneral.aspx",[this.AV11GestorCod]);
this.AV9Tab.Link=gx.http.formatLink("viewgestores.aspx",[this.AV11GestorCod,this.AV9Tab.Code]);this.AV8Tabs.push(this.AV9Tab);this.AV9Tab={Code:"",Description:"",Link:"",WebComponent:""};this.AV9Tab.Code="GPO_GES";this.AV9Tab.Description="Grupo de Gestión";this.AV9Tab.WebComponent=gx.http.formatLink("gestoresgpo_geswc.aspx",[this.AV11GestorCod]);this.AV9Tab.Link=gx.http.formatLink("viewgestores.aspx",[this.AV11GestorCod,this.AV9Tab.Code]);this.AV8Tabs.push(this.AV9Tab)};this.e130z2_client=function(){this.executeServerEvent("ENTER",true)
};this.e140z2_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];this.GXCtrlIds=[2,5,14,19];this.GXLastCtrlId=19;this.GXValidFnc[2]={fld:"VIEWTABLE",grid:0};this.GXValidFnc[5]={fld:"TITLETABLE",grid:0};this.GXValidFnc[8]={fld:"VIEWTITLE",format:0,grid:0};this.GXValidFnc[9]={fld:"SETEO",format:1,grid:0};this.GXValidFnc[11]={fld:"VIEWALL",format:0,grid:0};this.GXValidFnc[14]={fld:"TABLE1",grid:0};this.GXValidFnc[17]={fld:"FIXTEXTGESTORDES",format:0,grid:0};this.GXValidFnc[19]={lvl:0,type:"char",len:50,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"GESTORDES",gxz:"Z269GestorDes",gxold:"O269GestorDes",gxvar:"A269GestorDes",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A269GestorDes=a
},v2z:function(a){gx.O.Z269GestorDes=a},v2c:function(){gx.fn.setControlValue("GESTORDES",gx.O.A269GestorDes,0)},c2v:function(){gx.O.A269GestorDes=this.val()},val:function(){return gx.fn.getControlValue("GESTORDES")},nac:function(){return false}};this.GXValidFnc[20]={fld:"SPACESEPARATOR",format:0,grid:0};this.A269GestorDes="";this.Z269GestorDes="";this.O269GestorDes="";this.AV11GestorCod="";this.AV7TabCode="";this.A260GestorCod="";this.AV9Tab={};this.AV8Tabs=[];this.ServerEvents=["e130z2_client","e140z2_client"];
this.VarControlMap.AV11GestorCod={id:"vGESTORCOD",grid:0,type:"char"};this.VarControlMap.AV7TabCode={id:"vTABCODE",grid:0,type:"char"};this.SetStandaloneVars();this.setComponent({id:"TABBEDVIEW",GXClass:null,Prefix:"W0023",lvl:1})}viewgestores.prototype=new gx.GxObject;gx.setParentObj(new viewgestores());