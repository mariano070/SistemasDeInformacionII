/*
               File: WWTSEG002
        Description: Work With ACT. USUARIOS
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:8:22.85
       Program type: Main program
          Main DBMS: sqlserver
*/
gx.evt.autoSkip = false;
function wwtseg002() {
   this.ServerClass =  "WWTSEG002" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.hasEnterEvent = false;
   this.autoRefresh = true;
   this.SetStandaloneVars=function()
   {
   };
   this.e110f2_client=function()
   {
      this.executeServerEvent("'DOINSERT'", true, arguments[0]);
   };
   this.e150f2_client=function()
   {
      this.executeServerEvent("ENTER", true, arguments[0]);
   };
   this.e160f2_client=function()
   {
      this.executeServerEvent("CANCEL", true, arguments[0]);
   };
   this.GXValidFnc = [];
   this.GXCtrlIds=[2,8,13,19,23,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43];
   this.GXLastCtrlId =43;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",26,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"wwtseg002",[],false,1,false,true,0,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");
   this.GridContainer.addBitmap("&Update","vUPDATE",27,0,"px",17,"px",null,"","");
   this.GridContainer.addBitmap("&Delete","vDELETE",28,0,"px",17,"px",null,"","");
   this.GridContainer.addSingleLineEdit(6,29,"USU_COD","CODIGO","","USU_COD","char",0,"px",16,16,"left",null,[],6,"USU_COD",true,0,false,false);
   this.GridContainer.addSingleLineEdit(7,30,"USU_DES","DESCRIPCION","","USU_DES","char",0,"px",50,50,"left",null,[],7,"USU_DES",true,0,false,false);
   this.GridContainer.addSingleLineEdit(155,31,"USU_CLA","CONTRASEÑA","","USU_CLA","char",0,"px",20,20,"left",null,[],155,"USU_CLA",false,0,false,true);
   this.GridContainer.addSingleLineEdit(156,32,"USU_FEC","FECHA DE CONTRASEÑA","","USU_FEC","date",0,"px",10,10,"right",null,[],156,"USU_FEC",true,0,false,false);
   this.GridContainer.addSingleLineEdit(250,33,"USU_CDA","CODIGO ANTERIOR","","USU_CDA","char",0,"px",8,8,"left",null,[],250,"USU_CDA",true,0,false,false);
   this.GridContainer.addSingleLineEdit(251,34,"USU_EMP","EMPRESA","","USU_EMP","char",0,"px",3,3,"left",null,[],251,"USU_EMP",true,0,false,false);
   this.GridContainer.addSingleLineEdit(252,35,"USU_LEG","NUMERO DE LEGAJO RHM","","USU_LEG","int",0,"px",5,5,"right",null,[],252,"USU_LEG",true,0,false,false);
   this.GridContainer.addSingleLineEdit(180,36,"USU_INT","NRO. TELEFONO INTERNO","","USU_INT","char",0,"px",10,10,"left",null,[],180,"USU_INT",true,0,false,false);
   this.GridContainer.addSingleLineEdit(253,37,"USU_CLAK","A ENCRIPTADA","","USU_CLAK","char",0,"px",32,32,"left",null,[],253,"USU_CLAK",true,0,false,false);
   this.GridContainer.addSingleLineEdit(249,38,"USU_MAIW","EN WEB","","USU_MAIW","svchar",0,"px",256,256,"left",null,[],249,"USU_MAIW",true,0,false,false);
   this.GridContainer.addSingleLineEdit(254,39,"USU_TIPW","USUARIO WEB","","USU_TIPW","char",0,"px",1,1,"left",null,[],254,"USU_TIPW",true,0,false,false);
   this.GridContainer.addSingleLineEdit(255,40,"USU_NROW","PRESTADOR/ ENTIDAD","","USU_NROW","int",0,"px",11,11,"right",null,[],255,"USU_NROW",true,0,false,false);
   this.GridContainer.addSingleLineEdit(256,41,"USU_STS","EN WEB","","USU_STS","int",0,"px",2,2,"right",null,[],256,"USU_STS",true,0,false,false);
   this.GridContainer.addSingleLineEdit(257,42,"USU_ACTIV","ACTIVACION","","USU_ACTIV","dtime",0,"px",14,8,"right",null,[],257,"USU_ACTIV",true,5,false,false);
   this.GridContainer.addSingleLineEdit(258,43,"USU_ERR","CLAVE","","USU_ERR","int",0,"px",4,4,"right",null,[],258,"USU_ERR",true,0,false,false);
   this.setGrid(this.GridContainer);
   this.GXValidFnc[2]={fld:"TABLE",grid:0};
   this.GXValidFnc[5]={fld:"TITLETEXT", format:0,grid:0};
   this.GXValidFnc[8]={fld:"TABLESEARCH",grid:0};
   this.GXValidFnc[11]={fld:"FILTERTEXTUSU_DES", format:0,grid:0};
   this.GXValidFnc[13]={lvl:0,type:"char",len:50,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vUSU_DES",gxz:"ZV13USU_DES",gxold:"OV13USU_DES",gxvar:"AV13USU_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV13USU_DES=Value},v2z:function(Value){gx.O.ZV13USU_DES=Value},v2c:function(){gx.fn.setControlValue("vUSU_DES",gx.O.AV13USU_DES,0)},c2v:function(){gx.O.AV13USU_DES=this.val()},val:function(){return gx.fn.getControlValue("vUSU_DES")},nac:function(){return  false }};
   this.GXValidFnc[16]={fld:"TABLESEPARATOR", format:0,grid:0};
   this.GXValidFnc[19]={fld:"TABLEGRIDCONTAINER",grid:0};
   this.GXValidFnc[23]={fld:"INSERT",grid:0};
   this.GXValidFnc[27]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"vUPDATE",gxz:"ZV14Update",gxold:"OV14Update",gxvar:"AV14Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV14Update=Value},v2z:function(Value){gx.O.ZV14Update=Value},v2c:function(){},c2v:function(){gx.O.AV14Update=this.val()},val:function(){return gx.fn.getGridControlValue("vUPDATE",gx.fn.currentGridRowImpl(26))},nac:function(){return  false }};
   this.GXValidFnc[28]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"vDELETE",gxz:"ZV15Delete",gxold:"OV15Delete",gxvar:"AV15Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV15Delete=Value},v2z:function(Value){gx.O.ZV15Delete=Value},v2c:function(){},c2v:function(){gx.O.AV15Delete=this.val()},val:function(){return gx.fn.getGridControlValue("vDELETE",gx.fn.currentGridRowImpl(26))},nac:function(){return  false }};
   this.GXValidFnc[29]={lvl:2,type:"char",len:16,dec:0,sign:false,ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"USU_COD",gxz:"Z6USU_COD",gxold:"O6USU_COD",gxvar:"A6USU_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A6USU_COD=Value},v2z:function(Value){gx.O.Z6USU_COD=Value},v2c:function(){gx.fn.setGridControlValue("USU_COD",gx.fn.currentGridRowImpl(26),gx.O.A6USU_COD,0)},c2v:function(){gx.O.A6USU_COD=this.val()},val:function(){return gx.fn.getGridControlValue("USU_COD",gx.fn.currentGridRowImpl(26))},nac:function(){return  false }};
   this.GXValidFnc[30]={lvl:2,type:"char",len:50,dec:0,sign:false,ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"USU_DES",gxz:"Z7USU_DES",gxold:"O7USU_DES",gxvar:"A7USU_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A7USU_DES=Value},v2z:function(Value){gx.O.Z7USU_DES=Value},v2c:function(){gx.fn.setGridControlValue("USU_DES",gx.fn.currentGridRowImpl(26),gx.O.A7USU_DES,0)},c2v:function(){gx.O.A7USU_DES=this.val()},val:function(){return gx.fn.getGridControlValue("USU_DES",gx.fn.currentGridRowImpl(26))},nac:function(){return  false }};
   this.GXValidFnc[31]={lvl:2,type:"char",len:20,dec:0,sign:false,isPwd:true,ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"USU_CLA",gxz:"Z155USU_CLA",gxold:"O155USU_CLA",gxvar:"A155USU_CLA",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A155USU_CLA=Value},v2z:function(Value){gx.O.Z155USU_CLA=Value},v2c:function(){gx.fn.setGridControlValue("USU_CLA",gx.fn.currentGridRowImpl(26),gx.O.A155USU_CLA,0)},c2v:function(){gx.O.A155USU_CLA=this.val()},val:function(){return gx.fn.getGridControlValue("USU_CLA",gx.fn.currentGridRowImpl(26))},nac:function(){return  false }};
   this.GXValidFnc[32]={lvl:2,type:"date",len:10,dec:0,sign:false,ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"USU_FEC",gxz:"Z156USU_FEC",gxold:"O156USU_FEC",gxvar:"A156USU_FEC",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A156USU_FEC=gx.fn.toDatetimeValue(Value)},v2z:function(Value){gx.O.Z156USU_FEC=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setGridControlValue("USU_FEC",gx.fn.currentGridRowImpl(26),gx.O.A156USU_FEC,0)},c2v:function(){gx.O.A156USU_FEC=this.val()},val:function(){return gx.fn.getGridControlValue("USU_FEC",gx.fn.currentGridRowImpl(26))},nac:function(){return  false }};
   this.GXValidFnc[33]={lvl:2,type:"char",len:8,dec:0,sign:false,ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"USU_CDA",gxz:"Z250USU_CDA",gxold:"O250USU_CDA",gxvar:"A250USU_CDA",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A250USU_CDA=Value},v2z:function(Value){gx.O.Z250USU_CDA=Value},v2c:function(){gx.fn.setGridControlValue("USU_CDA",gx.fn.currentGridRowImpl(26),gx.O.A250USU_CDA,0)},c2v:function(){gx.O.A250USU_CDA=this.val()},val:function(){return gx.fn.getGridControlValue("USU_CDA",gx.fn.currentGridRowImpl(26))},nac:function(){return  false }};
   this.GXValidFnc[34]={lvl:2,type:"char",len:3,dec:0,sign:false,ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"USU_EMP",gxz:"Z251USU_EMP",gxold:"O251USU_EMP",gxvar:"A251USU_EMP",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A251USU_EMP=Value},v2z:function(Value){gx.O.Z251USU_EMP=Value},v2c:function(){gx.fn.setGridControlValue("USU_EMP",gx.fn.currentGridRowImpl(26),gx.O.A251USU_EMP,0)},c2v:function(){gx.O.A251USU_EMP=this.val()},val:function(){return gx.fn.getGridControlValue("USU_EMP",gx.fn.currentGridRowImpl(26))},nac:function(){return  false }};
   this.GXValidFnc[35]={lvl:2,type:"int",len:5,dec:0,sign:false,pic:"ZZZZ9",ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"USU_LEG",gxz:"Z252USU_LEG",gxold:"O252USU_LEG",gxvar:"A252USU_LEG",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A252USU_LEG=gx.num.intval(Value)},v2z:function(Value){gx.O.Z252USU_LEG=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("USU_LEG",gx.fn.currentGridRowImpl(26),gx.O.A252USU_LEG,0)},c2v:function(){gx.O.A252USU_LEG=this.val()},val:function(){return gx.fn.getGridIntegerValue("USU_LEG",gx.fn.currentGridRowImpl(26),'.')},nac:function(){return  false }};
   this.GXValidFnc[36]={lvl:2,type:"char",len:10,dec:0,sign:false,ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"USU_INT",gxz:"Z180USU_INT",gxold:"O180USU_INT",gxvar:"A180USU_INT",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A180USU_INT=Value},v2z:function(Value){gx.O.Z180USU_INT=Value},v2c:function(){gx.fn.setGridControlValue("USU_INT",gx.fn.currentGridRowImpl(26),gx.O.A180USU_INT,0)},c2v:function(){gx.O.A180USU_INT=this.val()},val:function(){return gx.fn.getGridControlValue("USU_INT",gx.fn.currentGridRowImpl(26))},nac:function(){return  false }};
   this.GXValidFnc[37]={lvl:2,type:"char",len:32,dec:0,sign:false,ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"USU_CLAK",gxz:"Z253USU_CLAK",gxold:"O253USU_CLAK",gxvar:"A253USU_CLAK",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A253USU_CLAK=Value},v2z:function(Value){gx.O.Z253USU_CLAK=Value},v2c:function(){gx.fn.setGridControlValue("USU_CLAK",gx.fn.currentGridRowImpl(26),gx.O.A253USU_CLAK,0)},c2v:function(){gx.O.A253USU_CLAK=this.val()},val:function(){return gx.fn.getGridControlValue("USU_CLAK",gx.fn.currentGridRowImpl(26))},nac:function(){return  false }};
   this.GXValidFnc[38]={lvl:2,type:"svchar",len:256,dec:0,sign:false,ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"USU_MAIW",gxz:"Z249USU_MAIW",gxold:"O249USU_MAIW",gxvar:"A249USU_MAIW",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A249USU_MAIW=Value},v2z:function(Value){gx.O.Z249USU_MAIW=Value},v2c:function(){gx.fn.setGridControlValue("USU_MAIW",gx.fn.currentGridRowImpl(26),gx.O.A249USU_MAIW,0)},c2v:function(){gx.O.A249USU_MAIW=this.val()},val:function(){return gx.fn.getGridControlValue("USU_MAIW",gx.fn.currentGridRowImpl(26))},nac:function(){return  false }};
   this.GXValidFnc[39]={lvl:2,type:"char",len:1,dec:0,sign:false,ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"USU_TIPW",gxz:"Z254USU_TIPW",gxold:"O254USU_TIPW",gxvar:"A254USU_TIPW",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A254USU_TIPW=Value},v2z:function(Value){gx.O.Z254USU_TIPW=Value},v2c:function(){gx.fn.setGridControlValue("USU_TIPW",gx.fn.currentGridRowImpl(26),gx.O.A254USU_TIPW,0)},c2v:function(){gx.O.A254USU_TIPW=this.val()},val:function(){return gx.fn.getGridControlValue("USU_TIPW",gx.fn.currentGridRowImpl(26))},nac:function(){return  false }};
   this.GXValidFnc[40]={lvl:2,type:"int",len:11,dec:0,sign:false,pic:"ZZZZZZZZZZ9",ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"USU_NROW",gxz:"Z255USU_NROW",gxold:"O255USU_NROW",gxvar:"A255USU_NROW",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A255USU_NROW=gx.num.intval(Value)},v2z:function(Value){gx.O.Z255USU_NROW=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("USU_NROW",gx.fn.currentGridRowImpl(26),gx.O.A255USU_NROW,0)},c2v:function(){gx.O.A255USU_NROW=this.val()},val:function(){return gx.fn.getGridIntegerValue("USU_NROW",gx.fn.currentGridRowImpl(26),'.')},nac:function(){return  false }};
   this.GXValidFnc[41]={lvl:2,type:"int",len:2,dec:0,sign:true,pic:"Z9",ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"USU_STS",gxz:"Z256USU_STS",gxold:"O256USU_STS",gxvar:"A256USU_STS",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A256USU_STS=gx.num.intval(Value)},v2z:function(Value){gx.O.Z256USU_STS=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("USU_STS",gx.fn.currentGridRowImpl(26),gx.O.A256USU_STS,0)},c2v:function(){gx.O.A256USU_STS=this.val()},val:function(){return gx.fn.getGridIntegerValue("USU_STS",gx.fn.currentGridRowImpl(26),'.')},nac:function(){return  false }};
   this.GXValidFnc[42]={lvl:2,type:"dtime",len:8,dec:5,sign:false,ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"USU_ACTIV",gxz:"Z257USU_ACTIV",gxold:"O257USU_ACTIV",gxvar:"A257USU_ACTIV",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/99 99:99",dec:5},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A257USU_ACTIV=gx.fn.toDatetimeValue(Value)},v2z:function(Value){gx.O.Z257USU_ACTIV=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setGridControlValue("USU_ACTIV",gx.fn.currentGridRowImpl(26),gx.O.A257USU_ACTIV,0)},c2v:function(){gx.O.A257USU_ACTIV=this.val()},val:function(){return gx.fn.getGridControlValue("USU_ACTIV",gx.fn.currentGridRowImpl(26))},nac:function(){return  false }};
   this.GXValidFnc[43]={lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"USU_ERR",gxz:"Z258USU_ERR",gxold:"O258USU_ERR",gxvar:"A258USU_ERR",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A258USU_ERR=gx.num.intval(Value)},v2z:function(Value){gx.O.Z258USU_ERR=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("USU_ERR",gx.fn.currentGridRowImpl(26),gx.O.A258USU_ERR,0)},c2v:function(){gx.O.A258USU_ERR=this.val()},val:function(){return gx.fn.getGridIntegerValue("USU_ERR",gx.fn.currentGridRowImpl(26),'.')},nac:function(){return  false }};
   this.AV13USU_DES = "" ;
   this.ZV13USU_DES = "" ;
   this.OV13USU_DES = "" ;
   this.ZV14Update = "" ;
   this.OV14Update = "" ;
   this.ZV15Delete = "" ;
   this.OV15Delete = "" ;
   this.Z6USU_COD = "" ;
   this.O6USU_COD = "" ;
   this.Z7USU_DES = "" ;
   this.O7USU_DES = "" ;
   this.Z155USU_CLA = "" ;
   this.O155USU_CLA = "" ;
   this.Z156USU_FEC = gx.date.nullDate() ;
   this.O156USU_FEC = gx.date.nullDate() ;
   this.Z250USU_CDA = "" ;
   this.O250USU_CDA = "" ;
   this.Z251USU_EMP = "" ;
   this.O251USU_EMP = "" ;
   this.Z252USU_LEG = 0 ;
   this.O252USU_LEG = 0 ;
   this.Z180USU_INT = "" ;
   this.O180USU_INT = "" ;
   this.Z253USU_CLAK = "" ;
   this.O253USU_CLAK = "" ;
   this.Z249USU_MAIW = "" ;
   this.O249USU_MAIW = "" ;
   this.Z254USU_TIPW = "" ;
   this.O254USU_TIPW = "" ;
   this.Z255USU_NROW = 0 ;
   this.O255USU_NROW = 0 ;
   this.Z256USU_STS = 0 ;
   this.O256USU_STS = 0 ;
   this.Z257USU_ACTIV = gx.date.nullDate() ;
   this.O257USU_ACTIV = gx.date.nullDate() ;
   this.Z258USU_ERR = 0 ;
   this.O258USU_ERR = 0 ;
   this.AV14Update = "" ;
   this.AV15Delete = "" ;
   this.A6USU_COD = "" ;
   this.A7USU_DES = "" ;
   this.A155USU_CLA = "" ;
   this.A156USU_FEC = gx.date.nullDate() ;
   this.A250USU_CDA = "" ;
   this.A251USU_EMP = "" ;
   this.A252USU_LEG = 0 ;
   this.A180USU_INT = "" ;
   this.A253USU_CLAK = "" ;
   this.A249USU_MAIW = "" ;
   this.A254USU_TIPW = "" ;
   this.A255USU_NROW = 0 ;
   this.A256USU_STS = 0 ;
   this.A257USU_ACTIV = gx.date.nullDate() ;
   this.A258USU_ERR = 0 ;
   this.ServerEvents = ["e110f2_client" ,"e150f2_client" ,"e160f2_client"];
   this.GridContainer.addRefreshingVar(this.GXValidFnc[13]);
   this.GridContainer.addRefreshingVar({rfrVar:"AV15Delete", rfrProp:"Tooltiptext"});
   this.GridContainer.addRefreshingVar({rfrVar:"AV15Delete", rfrProp:"Value"});
   this.GridContainer.addRefreshingVar({rfrVar:"AV14Update", rfrProp:"Tooltiptext"});
   this.GridContainer.addRefreshingVar({rfrVar:"AV14Update", rfrProp:"Value"});
   this.SetStandaloneVars( );
}
wwtseg002.prototype = new gx.GxObject;
gx.setParentObj(new wwtseg002());
