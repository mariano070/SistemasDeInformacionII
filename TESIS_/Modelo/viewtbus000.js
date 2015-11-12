/*
               File: ViewTBUS000
        Description: View TBUS000
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:8:3.13
       Program type: Callable routine
          Main DBMS: sqlserver
*/
gx.evt.autoSkip = false;
function viewtbus000() {
   this.ServerClass =  "ViewTBUS000" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.hasEnterEvent = false;
   this.autoRefresh = true;
   this.SetStandaloneVars=function()
   {
      this.AV11BUS_EMP=gx.fn.getControlValue("vBUS_EMP") ;
      this.AV12BUS_RUB=gx.fn.getIntegerValue("vBUS_RUB",'.') ;
      this.AV13BUS_COD=gx.fn.getIntegerValue("vBUS_COD",'.') ;
      this.AV14BUS_PAR=gx.fn.getIntegerValue("vBUS_PAR",'.') ;
      this.AV7TabCode=gx.fn.getControlValue("vTABCODE") ;
   };
   this.s112_client=function()
   {
      this.AV8Tabs = [ ] ;
      this.AV9Tab = {Code:"",Description:"",Link:"",WebComponent:""} ;
      this.AV9Tab.Code = "General" ;
      this.AV9Tab.Description = "General" ;
      this.AV9Tab.WebComponent = gx.http.formatLink("tbus000general.aspx",[this.AV11BUS_EMP, this.AV12BUS_RUB, this.AV13BUS_COD, this.AV14BUS_PAR]) ;
      this.AV9Tab.Link = gx.http.formatLink("viewtbus000.aspx",[this.AV11BUS_EMP, this.AV12BUS_RUB, this.AV13BUS_COD, this.AV14BUS_PAR, this.AV9Tab.Code]) ;
      this.AV8Tabs.push(this.AV9Tab) ;
   };
   this.e132c2_client=function()
   {
      this.executeServerEvent("ENTER", true);
   };
   this.e142c2_client=function()
   {
      this.executeServerEvent("CANCEL", true);
   };
   this.GXValidFnc = [];
   this.GXCtrlIds=[2,5,13,18];
   this.GXLastCtrlId =18;
   this.GXValidFnc[2]={fld:"VIEWTABLE",grid:0};
   this.GXValidFnc[5]={fld:"TITLETABLE",grid:0};
   this.GXValidFnc[8]={fld:"VIEWTITLE", format:0,grid:0};
   this.GXValidFnc[10]={fld:"VIEWALL", format:0,grid:0};
   this.GXValidFnc[13]={fld:"TABLE1",grid:0};
   this.GXValidFnc[16]={fld:"FIXTEXTBUS_DES", format:0,grid:0};
   this.GXValidFnc[18]={lvl:0,type:"char",len:50,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"BUS_DES",gxz:"Z54BUS_DES",gxold:"O54BUS_DES",gxvar:"A54BUS_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A54BUS_DES=Value},v2z:function(Value){gx.O.Z54BUS_DES=Value},v2c:function(){gx.fn.setControlValue("BUS_DES",gx.O.A54BUS_DES,0)},c2v:function(){gx.O.A54BUS_DES=this.val()},val:function(){return gx.fn.getControlValue("BUS_DES")},nac:function(){return  false }};
   this.GXValidFnc[19]={fld:"SPACESEPARATOR", format:0,grid:0};
   this.A54BUS_DES = "" ;
   this.Z54BUS_DES = "" ;
   this.O54BUS_DES = "" ;
   this.AV11BUS_EMP = "" ;
   this.AV12BUS_RUB = 0 ;
   this.AV13BUS_COD = 0 ;
   this.AV14BUS_PAR = 0 ;
   this.AV7TabCode = "" ;
   this.A4BUS_PAR = 0 ;
   this.A3BUS_COD = 0 ;
   this.A1BUS_RUB = 0 ;
   this.A8BUS_EMP = "" ;
   this.AV9Tab = {} ;
   this.AV8Tabs = [ ] ;
   this.ServerEvents = ["e132c2_client" ,"e142c2_client"];
   this.VarControlMap["AV11BUS_EMP"] = {id:"vBUS_EMP",grid:0,type:"char"};
   this.VarControlMap["AV12BUS_RUB"] = {id:"vBUS_RUB",grid:0,type:"int"};
   this.VarControlMap["AV13BUS_COD"] = {id:"vBUS_COD",grid:0,type:"int"};
   this.VarControlMap["AV14BUS_PAR"] = {id:"vBUS_PAR",grid:0,type:"int"};
   this.VarControlMap["AV7TabCode"] = {id:"vTABCODE",grid:0,type:"char"};
   this.SetStandaloneVars( );
   this.setComponent({id: "TABBEDVIEW" ,GXClass: null , Prefix: "W0022" , lvl: 1 });
}
viewtbus000.prototype = new gx.GxObject;
gx.setParentObj(new viewtbus000());
