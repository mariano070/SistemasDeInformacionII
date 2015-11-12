/*
               File: Gx00O0
        Description: Selection List BUS000
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:7:49.5
       Program type: Callable routine
          Main DBMS: sqlserver
*/
gx.evt.autoSkip = false;
function gx00o0() {
   this.ServerClass =  "Gx00O0" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.hasEnterEvent = true;
   this.autoRefresh = true;
   this.SetStandaloneVars=function()
   {
      this.AV15pBUS_EMP=gx.fn.getControlValue("vPBUS_EMP") ;
      this.AV16pBUS_RUB=gx.fn.getIntegerValue("vPBUS_RUB",'.') ;
      this.AV17pBUS_COD=gx.fn.getIntegerValue("vPBUS_COD",'.') ;
      this.AV18pBUS_PAR=gx.fn.getIntegerValue("vPBUS_PAR",'.') ;
   };
   this.e132k2_client=function()
   {
      this.executeServerEvent("ENTER", true, arguments[0]);
   };
   this.e142k2_client=function()
   {
      this.executeServerEvent("CANCEL", true, arguments[0]);
   };
   this.GXValidFnc = [];
   this.GXCtrlIds=[2,8,9,14,19,24,29,34,39,44,47,48,52,53,54,55,56,57,58,61];
   this.GXLastCtrlId =61;
   this.Grid1Container = new gx.grid.grid(this, 2,"WbpLvl2",51,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx00o0",[],false,1,false,true,10,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");
   this.Grid1Container.addBitmap("&Linkselection","vLINKSELECTION",52,0,"px",17,"px",null,"","");
   this.Grid1Container.addSingleLineEdit(8,53,"BUS_EMP","CODIGO DE EMPRESA","","BUS_EMP","char",0,"px",1,1,"left",null,[],8,"BUS_EMP",true,0,false,false);
   this.Grid1Container.addSingleLineEdit(1,54,"BUS_RUB","RUBRO DEL BIEN","","BUS_RUB","int",0,"px",4,4,"right",null,[],1,"BUS_RUB",true,0,false,false);
   this.Grid1Container.addSingleLineEdit(3,55,"BUS_COD","NUMERO DE CODIGO DEL BIEN","","BUS_COD","int",0,"px",4,4,"right",null,[],3,"BUS_COD",true,0,false,false);
   this.Grid1Container.addSingleLineEdit(4,56,"BUS_PAR","NUMERO DE PARTIDA DEL BIEN","","BUS_PAR","int",0,"px",2,2,"right",null,[],4,"BUS_PAR",true,0,false,false);
   this.Grid1Container.addSingleLineEdit(170,57,"BUS_FAL","FECHA DE ALTA DEL BIEN","","BUS_FAL","date",0,"px",10,10,"right",null,[],170,"BUS_FAL",true,0,false,false);
   this.Grid1Container.addSingleLineEdit(331,58,"BUS_COM","COMPROBANTE DE COMPRA","","BUS_COM","char",0,"px",2,2,"left",null,[],331,"BUS_COM",true,0,false,false);
   this.setGrid(this.Grid1Container);
   this.GXValidFnc[2]={fld:"TABLE1",grid:0};
   this.GXValidFnc[8]={fld:"GROUP1",grid:0};
   this.GXValidFnc[9]={fld:"TABLE2",grid:0};
   this.GXValidFnc[12]={fld:"TEXTBLOCKBUS_EMP", format:0,grid:0};
   this.GXValidFnc[14]={lvl:0,type:"char",len:1,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCBUS_EMP",gxz:"ZV6cBUS_EMP",gxold:"OV6cBUS_EMP",gxvar:"AV6cBUS_EMP",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV6cBUS_EMP=Value},v2z:function(Value){gx.O.ZV6cBUS_EMP=Value},v2c:function(){gx.fn.setControlValue("vCBUS_EMP",gx.O.AV6cBUS_EMP,0)},c2v:function(){gx.O.AV6cBUS_EMP=this.val()},val:function(){return gx.fn.getControlValue("vCBUS_EMP")},nac:function(){return  false }};
   this.GXValidFnc[17]={fld:"TEXTBLOCKBUS_RUB", format:0,grid:0};
   this.GXValidFnc[19]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCBUS_RUB",gxz:"ZV7cBUS_RUB",gxold:"OV7cBUS_RUB",gxvar:"AV7cBUS_RUB",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV7cBUS_RUB=gx.num.intval(Value)},v2z:function(Value){gx.O.ZV7cBUS_RUB=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vCBUS_RUB",gx.O.AV7cBUS_RUB,0)},c2v:function(){gx.O.AV7cBUS_RUB=this.val()},val:function(){return gx.fn.getIntegerValue("vCBUS_RUB",'.')},nac:function(){return  false }};
   this.GXValidFnc[22]={fld:"TEXTBLOCKBUS_COD", format:0,grid:0};
   this.GXValidFnc[24]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCBUS_COD",gxz:"ZV8cBUS_COD",gxold:"OV8cBUS_COD",gxvar:"AV8cBUS_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV8cBUS_COD=gx.num.intval(Value)},v2z:function(Value){gx.O.ZV8cBUS_COD=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vCBUS_COD",gx.O.AV8cBUS_COD,0)},c2v:function(){gx.O.AV8cBUS_COD=this.val()},val:function(){return gx.fn.getIntegerValue("vCBUS_COD",'.')},nac:function(){return  false }};
   this.GXValidFnc[27]={fld:"TEXTBLOCKBUS_PAR", format:0,grid:0};
   this.GXValidFnc[29]={lvl:0,type:"int",len:2,dec:0,sign:false,pic:"Z9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCBUS_PAR",gxz:"ZV9cBUS_PAR",gxold:"OV9cBUS_PAR",gxvar:"AV9cBUS_PAR",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV9cBUS_PAR=gx.num.intval(Value)},v2z:function(Value){gx.O.ZV9cBUS_PAR=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vCBUS_PAR",gx.O.AV9cBUS_PAR,0)},c2v:function(){gx.O.AV9cBUS_PAR=this.val()},val:function(){return gx.fn.getIntegerValue("vCBUS_PAR",'.')},nac:function(){return  false }};
   this.GXValidFnc[32]={fld:"TEXTBLOCKBUS_DES", format:0,grid:0};
   this.GXValidFnc[34]={lvl:0,type:"char",len:50,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCBUS_DES",gxz:"ZV12cBUS_DES",gxold:"OV12cBUS_DES",gxvar:"AV12cBUS_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV12cBUS_DES=Value},v2z:function(Value){gx.O.ZV12cBUS_DES=Value},v2c:function(){gx.fn.setControlValue("vCBUS_DES",gx.O.AV12cBUS_DES,0)},c2v:function(){gx.O.AV12cBUS_DES=this.val()},val:function(){return gx.fn.getControlValue("vCBUS_DES")},nac:function(){return  false }};
   this.GXValidFnc[37]={fld:"TEXTBLOCKBUS_FAL", format:0,grid:0};
   this.GXValidFnc[39]={lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCBUS_FAL",gxz:"ZV13cBUS_FAL",gxold:"OV13cBUS_FAL",gxvar:"AV13cBUS_FAL",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV13cBUS_FAL=gx.fn.toDatetimeValue(Value)},v2z:function(Value){gx.O.ZV13cBUS_FAL=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vCBUS_FAL",gx.O.AV13cBUS_FAL,0)},c2v:function(){gx.O.AV13cBUS_FAL=this.val()},val:function(){return gx.fn.getControlValue("vCBUS_FAL")},nac:function(){return  false }};
   this.GXValidFnc[42]={fld:"TEXTBLOCKBUS_FAD", format:0,grid:0};
   this.GXValidFnc[44]={lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCBUS_FAD",gxz:"ZV14cBUS_FAD",gxold:"OV14cBUS_FAD",gxvar:"AV14cBUS_FAD",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV14cBUS_FAD=gx.fn.toDatetimeValue(Value)},v2z:function(Value){gx.O.ZV14cBUS_FAD=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vCBUS_FAD",gx.O.AV14cBUS_FAD,0)},c2v:function(){gx.O.AV14cBUS_FAD=this.val()},val:function(){return gx.fn.getControlValue("vCBUS_FAD")},nac:function(){return  false }};
   this.GXValidFnc[47]={fld:"GROUP2",grid:0};
   this.GXValidFnc[48]={fld:"TABLE3",grid:0};
   this.GXValidFnc[52]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV5LinkSelection=Value},v2z:function(Value){gx.O.ZV5LinkSelection=Value},v2c:function(){},c2v:function(){gx.O.AV5LinkSelection=this.val()},val:function(){return gx.fn.getGridControlValue("vLINKSELECTION",gx.fn.currentGridRowImpl(51))},nac:function(){return  false }};
   this.GXValidFnc[53]={lvl:2,type:"char",len:1,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"BUS_EMP",gxz:"Z8BUS_EMP",gxold:"O8BUS_EMP",gxvar:"A8BUS_EMP",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A8BUS_EMP=Value},v2z:function(Value){gx.O.Z8BUS_EMP=Value},v2c:function(){gx.fn.setGridControlValue("BUS_EMP",gx.fn.currentGridRowImpl(51),gx.O.A8BUS_EMP,0)},c2v:function(){gx.O.A8BUS_EMP=this.val()},val:function(){return gx.fn.getGridControlValue("BUS_EMP",gx.fn.currentGridRowImpl(51))},nac:function(){return  false }};
   this.GXValidFnc[54]={lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"BUS_RUB",gxz:"Z1BUS_RUB",gxold:"O1BUS_RUB",gxvar:"A1BUS_RUB",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A1BUS_RUB=gx.num.intval(Value)},v2z:function(Value){gx.O.Z1BUS_RUB=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("BUS_RUB",gx.fn.currentGridRowImpl(51),gx.O.A1BUS_RUB,0)},c2v:function(){gx.O.A1BUS_RUB=this.val()},val:function(){return gx.fn.getGridIntegerValue("BUS_RUB",gx.fn.currentGridRowImpl(51),'.')},nac:function(){return  false }};
   this.GXValidFnc[55]={lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"BUS_COD",gxz:"Z3BUS_COD",gxold:"O3BUS_COD",gxvar:"A3BUS_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A3BUS_COD=gx.num.intval(Value)},v2z:function(Value){gx.O.Z3BUS_COD=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("BUS_COD",gx.fn.currentGridRowImpl(51),gx.O.A3BUS_COD,0)},c2v:function(){gx.O.A3BUS_COD=this.val()},val:function(){return gx.fn.getGridIntegerValue("BUS_COD",gx.fn.currentGridRowImpl(51),'.')},nac:function(){return  false }};
   this.GXValidFnc[56]={lvl:2,type:"int",len:2,dec:0,sign:false,pic:"Z9",ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"BUS_PAR",gxz:"Z4BUS_PAR",gxold:"O4BUS_PAR",gxvar:"A4BUS_PAR",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A4BUS_PAR=gx.num.intval(Value)},v2z:function(Value){gx.O.Z4BUS_PAR=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("BUS_PAR",gx.fn.currentGridRowImpl(51),gx.O.A4BUS_PAR,0)},c2v:function(){gx.O.A4BUS_PAR=this.val()},val:function(){return gx.fn.getGridIntegerValue("BUS_PAR",gx.fn.currentGridRowImpl(51),'.')},nac:function(){return  false }};
   this.GXValidFnc[57]={lvl:2,type:"date",len:10,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"BUS_FAL",gxz:"Z170BUS_FAL",gxold:"O170BUS_FAL",gxvar:"A170BUS_FAL",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A170BUS_FAL=gx.fn.toDatetimeValue(Value)},v2z:function(Value){gx.O.Z170BUS_FAL=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setGridControlValue("BUS_FAL",gx.fn.currentGridRowImpl(51),gx.O.A170BUS_FAL,0)},c2v:function(){gx.O.A170BUS_FAL=this.val()},val:function(){return gx.fn.getGridControlValue("BUS_FAL",gx.fn.currentGridRowImpl(51))},nac:function(){return  false }};
   this.GXValidFnc[58]={lvl:2,type:"char",len:2,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"BUS_COM",gxz:"Z331BUS_COM",gxold:"O331BUS_COM",gxvar:"A331BUS_COM",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A331BUS_COM=Value},v2z:function(Value){gx.O.Z331BUS_COM=Value},v2c:function(){gx.fn.setGridControlValue("BUS_COM",gx.fn.currentGridRowImpl(51),gx.O.A331BUS_COM,0)},c2v:function(){gx.O.A331BUS_COM=this.val()},val:function(){return gx.fn.getGridControlValue("BUS_COM",gx.fn.currentGridRowImpl(51))},nac:function(){return  false }};
   this.GXValidFnc[61]={fld:"TABLE4",grid:0};
   this.AV6cBUS_EMP = "" ;
   this.ZV6cBUS_EMP = "" ;
   this.OV6cBUS_EMP = "" ;
   this.AV7cBUS_RUB = 0 ;
   this.ZV7cBUS_RUB = 0 ;
   this.OV7cBUS_RUB = 0 ;
   this.AV8cBUS_COD = 0 ;
   this.ZV8cBUS_COD = 0 ;
   this.OV8cBUS_COD = 0 ;
   this.AV9cBUS_PAR = 0 ;
   this.ZV9cBUS_PAR = 0 ;
   this.OV9cBUS_PAR = 0 ;
   this.AV12cBUS_DES = "" ;
   this.ZV12cBUS_DES = "" ;
   this.OV12cBUS_DES = "" ;
   this.AV13cBUS_FAL = gx.date.nullDate() ;
   this.ZV13cBUS_FAL = gx.date.nullDate() ;
   this.OV13cBUS_FAL = gx.date.nullDate() ;
   this.AV14cBUS_FAD = gx.date.nullDate() ;
   this.ZV14cBUS_FAD = gx.date.nullDate() ;
   this.OV14cBUS_FAD = gx.date.nullDate() ;
   this.ZV5LinkSelection = "" ;
   this.OV5LinkSelection = "" ;
   this.Z8BUS_EMP = "" ;
   this.O8BUS_EMP = "" ;
   this.Z1BUS_RUB = 0 ;
   this.O1BUS_RUB = 0 ;
   this.Z3BUS_COD = 0 ;
   this.O3BUS_COD = 0 ;
   this.Z4BUS_PAR = 0 ;
   this.O4BUS_PAR = 0 ;
   this.Z170BUS_FAL = gx.date.nullDate() ;
   this.O170BUS_FAL = gx.date.nullDate() ;
   this.Z331BUS_COM = "" ;
   this.O331BUS_COM = "" ;
   this.AV15pBUS_EMP = "" ;
   this.AV16pBUS_RUB = 0 ;
   this.AV17pBUS_COD = 0 ;
   this.AV18pBUS_PAR = 0 ;
   this.A54BUS_DES = "" ;
   this.A55BUS_FAD = gx.date.nullDate() ;
   this.AV5LinkSelection = "" ;
   this.A8BUS_EMP = "" ;
   this.A1BUS_RUB = 0 ;
   this.A3BUS_COD = 0 ;
   this.A4BUS_PAR = 0 ;
   this.A170BUS_FAL = gx.date.nullDate() ;
   this.A331BUS_COM = "" ;
   this.ServerEvents = ["e132k2_client" ,"e142k2_client"];
   this.VarControlMap["AV15pBUS_EMP"] = {id:"vPBUS_EMP",grid:0,type:"char"};
   this.VarControlMap["AV16pBUS_RUB"] = {id:"vPBUS_RUB",grid:0,type:"int"};
   this.VarControlMap["AV17pBUS_COD"] = {id:"vPBUS_COD",grid:0,type:"int"};
   this.VarControlMap["AV18pBUS_PAR"] = {id:"vPBUS_PAR",grid:0,type:"int"};
   this.Grid1Container.addRefreshingVar(this.GXValidFnc[14]);
   this.Grid1Container.addRefreshingVar(this.GXValidFnc[19]);
   this.Grid1Container.addRefreshingVar(this.GXValidFnc[24]);
   this.Grid1Container.addRefreshingVar(this.GXValidFnc[29]);
   this.Grid1Container.addRefreshingVar(this.GXValidFnc[34]);
   this.Grid1Container.addRefreshingVar(this.GXValidFnc[39]);
   this.Grid1Container.addRefreshingVar(this.GXValidFnc[44]);
   this.SetStandaloneVars( );
}
gx00o0.prototype = new gx.GxObject;
gx.setParentObj(new gx00o0());
