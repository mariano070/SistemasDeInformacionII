gx.evt.autoSkip=false;function viewtseg002(){this.ServerClass="ViewTSEG002";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=false;this.autoRefresh=true;this.SetStandaloneVars=function(){this.AV11USU_COD=gx.fn.getControlValue("vUSU_COD");this.AV7TabCode=gx.fn.getControlValue("vTABCODE")};this.s112_client=function(){this.AV8Tabs=[];this.AV9Tab={Code:"",Description:"",Link:"",WebComponent:""};this.AV9Tab.Code="General";this.AV9Tab.Description="General";this.AV9Tab.WebComponent=gx.http.formatLink("tseg002general.aspx",[this.AV11USU_COD]);
this.AV9Tab.Link=gx.http.formatLink("viewtseg002.aspx",[this.AV11USU_COD,this.AV9Tab.Code]);this.AV8Tabs.push(this.AV9Tab);this.AV9Tab={Code:"",Description:"",Link:"",WebComponent:""};this.AV9Tab.Code="TSEG003";this.AV9Tab.Description="ACT. USUARIO/SISTEMA";this.AV9Tab.WebComponent=gx.http.formatLink("tseg002tseg003wc.aspx",[this.AV11USU_COD]);this.AV9Tab.Link=gx.http.formatLink("viewtseg002.aspx",[this.AV11USU_COD,this.AV9Tab.Code]);this.AV8Tabs.push(this.AV9Tab);this.AV9Tab={Code:"",Description:"",Link:"",WebComponent:""};
this.AV9Tab.Code="TTBUS007";this.AV9Tab.Description="Responsable de Posición";this.AV9Tab.WebComponent=gx.http.formatLink("tseg002ttbus007wc.aspx",[this.AV11USU_COD]);this.AV9Tab.Link=gx.http.formatLink("viewtseg002.aspx",[this.AV11USU_COD,this.AV9Tab.Code]);this.AV8Tabs.push(this.AV9Tab);this.AV9Tab={Code:"",Description:"",Link:"",WebComponent:""};this.AV9Tab.Code="Permisos";this.AV9Tab.Description="Usuario con acceso a posicion trazabilidad";this.AV9Tab.WebComponent=gx.http.formatLink("tseg002permisoswc.aspx",[this.AV11USU_COD]);
this.AV9Tab.Link=gx.http.formatLink("viewtseg002.aspx",[this.AV11USU_COD,this.AV9Tab.Code]);this.AV8Tabs.push(this.AV9Tab);this.AV9Tab={Code:"",Description:"",Link:"",WebComponent:""};this.AV9Tab.Code="TTBUS007_p";this.AV9Tab.Description="Usuario con acceso a posicion trazabilidad";this.AV9Tab.WebComponent=gx.http.formatLink("tseg002ttbus007_pwc.aspx",[this.AV11USU_COD]);this.AV9Tab.Link=gx.http.formatLink("viewtseg002.aspx",[this.AV11USU_COD,this.AV9Tab.Code]);this.AV8Tabs.push(this.AV9Tab);this.AV9Tab={Code:"",Description:"",Link:"",WebComponent:""};
this.AV9Tab.Code="TPRM005";this.AV9Tab.Description="Usuario";this.AV9Tab.WebComponent=gx.http.formatLink("tseg002tprm005wc.aspx",[this.AV11USU_COD]);this.AV9Tab.Link=gx.http.formatLink("viewtseg002.aspx",[this.AV11USU_COD,this.AV9Tab.Code]);this.AV8Tabs.push(this.AV9Tab)};this.e130o2_client=function(){this.executeServerEvent("ENTER",true)};this.e140o2_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];this.GXCtrlIds=[2,5,13,18];this.GXLastCtrlId=18;this.GXValidFnc[2]={fld:"VIEWTABLE",grid:0};
this.GXValidFnc[5]={fld:"TITLETABLE",grid:0};this.GXValidFnc[8]={fld:"VIEWTITLE",format:0,grid:0};this.GXValidFnc[10]={fld:"VIEWALL",format:0,grid:0};this.GXValidFnc[13]={fld:"TABLE1",grid:0};this.GXValidFnc[16]={fld:"FIXTEXTUSU_DES",format:0,grid:0};this.GXValidFnc[18]={lvl:0,type:"char",len:50,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"USU_DES",gxz:"Z7USU_DES",gxold:"O7USU_DES",gxvar:"A7USU_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A7USU_DES=a
},v2z:function(a){gx.O.Z7USU_DES=a},v2c:function(){gx.fn.setControlValue("USU_DES",gx.O.A7USU_DES,0)},c2v:function(){gx.O.A7USU_DES=this.val()},val:function(){return gx.fn.getControlValue("USU_DES")},nac:function(){return false}};this.GXValidFnc[19]={fld:"SPACESEPARATOR",format:0,grid:0};this.A7USU_DES="";this.Z7USU_DES="";this.O7USU_DES="";this.AV11USU_COD="";this.AV7TabCode="";this.A6USU_COD="";this.AV9Tab={};this.AV8Tabs=[];this.ServerEvents=["e130o2_client","e140o2_client"];this.VarControlMap.AV11USU_COD={id:"vUSU_COD",grid:0,type:"char"};
this.VarControlMap.AV7TabCode={id:"vTABCODE",grid:0,type:"char"};this.SetStandaloneVars();this.setComponent({id:"TABBEDVIEW",GXClass:null,Prefix:"W0022",lvl:1})}viewtseg002.prototype=new gx.GxObject;gx.setParentObj(new viewtseg002());