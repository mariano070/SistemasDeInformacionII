gx.evt.autoSkip=false;function gx0100(){this.ServerClass="Gx0100";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=true;this.autoRefresh=true;this.SetStandaloneVars=function(){this.AV10pVprPrc=gx.fn.getControlValue("vPVPRPRC")};this.e134p2_client=function(){this.executeServerEvent("ENTER",true,arguments[0])};this.e144p2_client=function(){this.executeServerEvent("CANCEL",true,arguments[0])};this.GXValidFnc=[];this.GXCtrlIds=[2,8,9,14,19,24,29,32,33,37,38,39,40,43];this.GXLastCtrlId=43;
this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",36,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0100",[],false,1,false,true,10,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");this.Grid1Container.addBitmap("&Linkselection","vLINKSELECTION",37,0,"px",17,"px",null,"","");this.Grid1Container.addSingleLineEdit(99,38,"VPRPRC","(en COLA)","","VprPrc","char",0,"px",20,20,"left",null,[],99,"VprPrc",true,0,false,false);this.Grid1Container.addSingleLineEdit(100,39,"VPRNOMBREX","version X","Seleccionar","VprNombreX","char",0,"px",20,20,"left",null,[],100,"VprNombreX",true,0,false,false);
this.Grid1Container.addSingleLineEdit(101,40,"VPRVER","X) ","","VprVer","char",0,"px",1,1,"left",null,[],101,"VprVer",true,0,false,false);this.setGrid(this.Grid1Container);this.GXValidFnc[2]={fld:"TABLE1",grid:0};this.GXValidFnc[8]={fld:"GROUP1",grid:0};this.GXValidFnc[9]={fld:"TABLE2",grid:0};this.GXValidFnc[12]={fld:"TEXTBLOCKVPRPRC",format:0,grid:0};this.GXValidFnc[14]={lvl:0,type:"char",len:20,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCVPRPRC",gxz:"ZV6cVprPrc",gxold:"OV6cVprPrc",gxvar:"AV6cVprPrc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV6cVprPrc=a
},v2z:function(a){gx.O.ZV6cVprPrc=a},v2c:function(){gx.fn.setControlValue("vCVPRPRC",gx.O.AV6cVprPrc,0)},c2v:function(){gx.O.AV6cVprPrc=this.val()},val:function(){return gx.fn.getControlValue("vCVPRPRC")},nac:function(){return false}};this.GXValidFnc[17]={fld:"TEXTBLOCKVPRNOMBREX",format:0,grid:0};this.GXValidFnc[19]={lvl:0,type:"char",len:20,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCVPRNOMBREX",gxz:"ZV7cVprNombreX",gxold:"OV7cVprNombreX",gxvar:"AV7cVprNombreX",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV7cVprNombreX=a
},v2z:function(a){gx.O.ZV7cVprNombreX=a},v2c:function(){gx.fn.setControlValue("vCVPRNOMBREX",gx.O.AV7cVprNombreX,0)},c2v:function(){gx.O.AV7cVprNombreX=this.val()},val:function(){return gx.fn.getControlValue("vCVPRNOMBREX")},nac:function(){return false}};this.GXValidFnc[22]={fld:"TEXTBLOCKVPRVER",format:0,grid:0};this.GXValidFnc[24]={lvl:0,type:"char",len:1,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCVPRVER",gxz:"ZV8cVprVer",gxold:"OV8cVprVer",gxvar:"AV8cVprVer",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV8cVprVer=a
},v2z:function(a){gx.O.ZV8cVprVer=a},v2c:function(){gx.fn.setControlValue("vCVPRVER",gx.O.AV8cVprVer,0)},c2v:function(){gx.O.AV8cVprVer=this.val()},val:function(){return gx.fn.getControlValue("vCVPRVER")},nac:function(){return false}};this.GXValidFnc[27]={fld:"TEXTBLOCKVPROBS",format:0,grid:0};this.GXValidFnc[29]={lvl:0,type:"char",len:75,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCVPROBS",gxz:"ZV9cVprObs",gxold:"OV9cVprObs",gxvar:"AV9cVprObs",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV9cVprObs=a
},v2z:function(a){gx.O.ZV9cVprObs=a},v2c:function(){gx.fn.setControlValue("vCVPROBS",gx.O.AV9cVprObs,0)},c2v:function(){gx.O.AV9cVprObs=this.val()},val:function(){return gx.fn.getControlValue("vCVPROBS")},nac:function(){return false}};this.GXValidFnc[32]={fld:"GROUP2",grid:0};this.GXValidFnc[33]={fld:"TABLE3",grid:0};this.GXValidFnc[37]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV5LinkSelection=a
},v2z:function(a){gx.O.ZV5LinkSelection=a},v2c:function(){},c2v:function(){gx.O.AV5LinkSelection=this.val()},val:function(){return gx.fn.getGridControlValue("vLINKSELECTION",gx.fn.currentGridRowImpl(36))},nac:function(){return false}};this.GXValidFnc[38]={lvl:2,type:"char",len:20,dec:0,sign:false,ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"VPRPRC",gxz:"Z99VprPrc",gxold:"O99VprPrc",gxvar:"A99VprPrc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A99VprPrc=a
},v2z:function(a){gx.O.Z99VprPrc=a},v2c:function(){gx.fn.setGridControlValue("VPRPRC",gx.fn.currentGridRowImpl(36),gx.O.A99VprPrc,0)},c2v:function(){gx.O.A99VprPrc=this.val()},val:function(){return gx.fn.getGridControlValue("VPRPRC",gx.fn.currentGridRowImpl(36))},nac:function(){return false}};this.GXValidFnc[39]={lvl:2,type:"char",len:20,dec:0,sign:false,ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"VPRNOMBREX",gxz:"Z100VprNombreX",gxold:"O100VprNombreX",gxvar:"A100VprNombreX",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A100VprNombreX=a
},v2z:function(a){gx.O.Z100VprNombreX=a},v2c:function(){gx.fn.setGridControlValue("VPRNOMBREX",gx.fn.currentGridRowImpl(36),gx.O.A100VprNombreX,0)},c2v:function(){gx.O.A100VprNombreX=this.val()},val:function(){return gx.fn.getGridControlValue("VPRNOMBREX",gx.fn.currentGridRowImpl(36))},nac:function(){return false}};this.GXValidFnc[40]={lvl:2,type:"char",len:1,dec:0,sign:false,ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"VPRVER",gxz:"Z101VprVer",gxold:"O101VprVer",gxvar:"A101VprVer",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A101VprVer=a
},v2z:function(a){gx.O.Z101VprVer=a},v2c:function(){gx.fn.setGridControlValue("VPRVER",gx.fn.currentGridRowImpl(36),gx.O.A101VprVer,0)},c2v:function(){gx.O.A101VprVer=this.val()},val:function(){return gx.fn.getGridControlValue("VPRVER",gx.fn.currentGridRowImpl(36))},nac:function(){return false}};this.GXValidFnc[43]={fld:"TABLE4",grid:0};this.AV6cVprPrc="";this.ZV6cVprPrc="";this.OV6cVprPrc="";this.AV7cVprNombreX="";this.ZV7cVprNombreX="";this.OV7cVprNombreX="";this.AV8cVprVer="";this.ZV8cVprVer="";
this.OV8cVprVer="";this.AV9cVprObs="";this.ZV9cVprObs="";this.OV9cVprObs="";this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z99VprPrc="";this.O99VprPrc="";this.Z100VprNombreX="";this.O100VprNombreX="";this.Z101VprVer="";this.O101VprVer="";this.AV10pVprPrc="";this.A410VprObs="";this.AV5LinkSelection="";this.A99VprPrc="";this.A100VprNombreX="";this.A101VprVer="";this.ServerEvents=["e134p2_client","e144p2_client"];this.VarControlMap.AV10pVprPrc={id:"vPVPRPRC",grid:0,type:"char"};this.Grid1Container.addRefreshingVar(this.GXValidFnc[14]);
this.Grid1Container.addRefreshingVar(this.GXValidFnc[19]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[24]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[29]);this.SetStandaloneVars()}gx0100.prototype=new gx.GxObject;gx.setParentObj(new gx0100());