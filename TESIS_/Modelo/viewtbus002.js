/*
               File: ViewTBUS002
        Description: View TBUS002
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:8:8.56
       Program type: Callable routine
          Main DBMS: sqlserver
*/
gx.evt.autoSkip = false;
function viewtbus002() {
   this.ServerClass =  "ViewTBUS002" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.hasEnterEvent = false;
   this.autoRefresh = true;
   this.SetStandaloneVars=function()
   {
      this.AV11RBR_COD=gx.fn.getIntegerValue("vRBR_COD",'.') ;
      this.AV7TabCode=gx.fn.getControlValue("vTABCODE") ;
   };
   this.s112_client=function()
   {
      this.AV8Tabs = [ ] ;
      this.AV9Tab = {Code:"",Description:"",Link:"",WebComponent:""} ;
      this.AV9Tab.Code = "General" ;
      this.AV9Tab.Description = "General" ;
      this.AV9Tab.WebComponent = gx.http.formatLink("tbus002general.aspx",[this.AV11RBR_COD]) ;
      this.AV9Tab.Link = gx.http.formatLink("viewtbus002.aspx",[this.AV11RBR_COD, this.AV9Tab.Code]) ;
      this.AV8Tabs.push(this.AV9Tab) ;
      this.AV9Tab = {Code:"",Description:"",Link:"",WebComponent:""} ;
      this.AV9Tab.Code = "TBUS000" ;
      this.AV9Tab.Description = "RUBRO BIENES DE USO" ;
      this.AV9Tab.WebComponent = gx.http.formatLink("tbus002tbus000wc.aspx",[this.AV11RBR_COD]) ;
      this.AV9Tab.Link = gx.http.formatLink("viewtbus002.aspx",[this.AV11RBR_COD, this.AV9Tab.Code]) ;
      this.AV8Tabs.push(this.AV9Tab) ;
      this.AV9Tab = {Code:"",Description:"",Link:"",WebComponent:""} ;
      this.AV9Tab.Code = "TTBUS000" ;
      this.AV9Tab.Description = "Bienes de Uso (Trazabilidad)" ;
      this.AV9Tab.WebComponent = gx.http.formatLink("tbus002ttbus000wc.aspx",[this.AV11RBR_COD]) ;
      this.AV9Tab.Link = gx.http.formatLink("viewtbus002.aspx",[this.AV11RBR_COD, this.AV9Tab.Code]) ;
      this.AV8Tabs.push(this.AV9Tab) ;
      this.AV9Tab = {Code:"",Description:"",Link:"",WebComponent:""} ;
      this.AV9Tab.Code = "TTBUS000_b" ;
      this.AV9Tab.Description = "Baja de un Bien de Uso" ;
      this.AV9Tab.WebComponent = gx.http.formatLink("tbus002ttbus000_bwc.aspx",[this.AV11RBR_COD]) ;
      this.AV9Tab.Link = gx.http.formatLink("viewtbus002.aspx",[this.AV11RBR_COD, this.AV9Tab.Code]) ;
      this.AV8Tabs.push(this.AV9Tab) ;
   };
   this.e13462_client=function()
   {
      this.executeServerEvent("ENTER", true);
   };
   this.e14462_client=function()
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
   this.GXValidFnc[16]={fld:"FIXTEXTRBR_DES", format:0,grid:0};
   this.GXValidFnc[18]={lvl:0,type:"char",len:30,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"RBR_DES",gxz:"Z19RBR_DES",gxold:"O19RBR_DES",gxvar:"A19RBR_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A19RBR_DES=Value},v2z:function(Value){gx.O.Z19RBR_DES=Value},v2c:function(){gx.fn.setControlValue("RBR_DES",gx.O.A19RBR_DES,0)},c2v:function(){gx.O.A19RBR_DES=this.val()},val:function(){return gx.fn.getControlValue("RBR_DES")},nac:function(){return  false }};
   this.GXValidFnc[19]={fld:"SPACESEPARATOR", format:0,grid:0};
   this.A19RBR_DES = "" ;
   this.Z19RBR_DES = "" ;
   this.O19RBR_DES = "" ;
   this.AV11RBR_COD = 0 ;
   this.AV7TabCode = "" ;
   this.A2RBR_COD = 0 ;
   this.AV9Tab = {} ;
   this.AV8Tabs = [ ] ;
   this.ServerEvents = ["e13462_client" ,"e14462_client"];
   this.VarControlMap["AV11RBR_COD"] = {id:"vRBR_COD",grid:0,type:"int"};
   this.VarControlMap["AV7TabCode"] = {id:"vTABCODE",grid:0,type:"char"};
   this.SetStandaloneVars( );
   this.setComponent({id: "TABBEDVIEW" ,GXClass: null , Prefix: "W0022" , lvl: 1 });
}
viewtbus002.prototype = new gx.GxObject;
gx.setParentObj(new viewtbus002());
