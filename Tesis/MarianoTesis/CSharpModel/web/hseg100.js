gx.evt.autoSkip=false;function hseg100(){this.ServerClass="HSEG100";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=false;this.autoRefresh=true;this.SetStandaloneVars=function(){this.AV8SISTEMA=gx.fn.getControlValue("vSISTEMA");this.AV7USUARIO=gx.fn.getControlValue("vUSUARIO")};this.e174t2_client=function(){this.clearMessages();this.refreshOutputs([])};this.e114t2_client=function(){this.executeServerEvent("'ALTA'",true,arguments[0])};this.e144t2_client=function(){this.executeServerEvent("'BAJA'",true,arguments[0])
};this.e154t2_client=function(){this.executeServerEvent("'MODIFICA'",true,arguments[0])};this.e124t2_client=function(){this.executeServerEvent("'PROGRAMAS'",false,arguments[0])};this.e184t2_client=function(){this.executeServerEvent("ENTER",true,arguments[0])};this.e194t2_client=function(){this.executeServerEvent("CANCEL",true,arguments[0])};this.GXValidFnc=[];this.GXCtrlIds=[3,6,10,15,18,23,24,25,26,27,30];this.GXLastCtrlId=30;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",22,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"hseg100",[],false,1,true,true,5,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");
this.Grid1Container.addBitmap("&Update","vUPDATE",23,0,"px",17,"px","e154t2_client","","");this.Grid1Container.addBitmap("&Delete","vDELETE",24,0,"px",17,"px","e144t2_client","","");this.Grid1Container.addSingleLineEdit(116,25,"SIS_COD","Código","","SIS_COD","int",83,"px",3,3,"right",null,[],116,"SIS_COD",true,0,false,false);this.Grid1Container.addSingleLineEdit(259,26,"SIS_DES","Sistema","","SIS_DES","char",371,"px",15,15,"left",null,[],259,"SIS_DES",true,0,false,false);this.Grid1Container.addBitmap("&Icono","vICONO",27,0,"px",40,"px",null,"","ICONO");
this.setGrid(this.Grid1Container);this.GXValidFnc[3]={fld:"TABLE1",grid:0};this.GXValidFnc[6]={fld:"TABLE3",grid:0};this.GXValidFnc[9]={fld:"TEXTBLOCK3",format:0,grid:0};this.GXValidFnc[10]={lvl:0,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vSIS_COD",gxz:"ZV15SIS_COD",gxold:"OV15SIS_COD",gxvar:"AV15SIS_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV15SIS_COD=gx.num.intval(a)},v2z:function(a){gx.O.ZV15SIS_COD=gx.num.intval(a)
},v2c:function(){gx.fn.setControlValue("vSIS_COD",gx.O.AV15SIS_COD,0)},c2v:function(){gx.O.AV15SIS_COD=this.val()},val:function(){return gx.fn.getIntegerValue("vSIS_COD",".")},nac:function(){return false}};this.GXValidFnc[14]={fld:"TEXTBLOCK2",format:0,grid:0};this.GXValidFnc[15]={lvl:0,type:"char",len:15,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vSISDES",gxz:"ZV5SISDES",gxold:"OV5SISDES",gxvar:"AV5SISDES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV5SISDES=a
},v2z:function(a){gx.O.ZV5SISDES=a},v2c:function(){gx.fn.setControlValue("vSISDES",gx.O.AV5SISDES,0)},c2v:function(){gx.O.AV5SISDES=this.val()},val:function(){return gx.fn.getControlValue("vSISDES")},nac:function(){return false}};this.GXValidFnc[18]={fld:"INSERT",grid:0};this.GXValidFnc[23]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:22,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vUPDATE",gxz:"ZV13Update",gxold:"OV13Update",gxvar:"AV13Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV13Update=a
},v2z:function(a){gx.O.ZV13Update=a},v2c:function(){},c2v:function(){gx.O.AV13Update=this.val()},val:function(){return gx.fn.getGridControlValue("vUPDATE",gx.fn.currentGridRowImpl(22))},nac:function(){return false}};this.GXValidFnc[24]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:22,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vDELETE",gxz:"ZV14Delete",gxold:"OV14Delete",gxvar:"AV14Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV14Delete=a},v2z:function(a){gx.O.ZV14Delete=a
},v2c:function(){},c2v:function(){gx.O.AV14Delete=this.val()},val:function(){return gx.fn.getGridControlValue("vDELETE",gx.fn.currentGridRowImpl(22))},nac:function(){return false}};this.GXValidFnc[25]={lvl:2,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:1,grid:22,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"SIS_COD",gxz:"Z116SIS_COD",gxold:"O116SIS_COD",gxvar:"A116SIS_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A116SIS_COD=gx.num.intval(a)},v2z:function(a){gx.O.Z116SIS_COD=gx.num.intval(a)
},v2c:function(){gx.fn.setGridControlValue("SIS_COD",gx.fn.currentGridRowImpl(22),gx.O.A116SIS_COD,1)},c2v:function(){gx.O.A116SIS_COD=this.val()},val:function(){return gx.fn.getGridIntegerValue("SIS_COD",gx.fn.currentGridRowImpl(22),".")},nac:function(){return false}};this.GXValidFnc[26]={lvl:2,type:"char",len:15,dec:0,sign:false,ro:1,grid:22,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"SIS_DES",gxz:"Z259SIS_DES",gxold:"O259SIS_DES",gxvar:"A259SIS_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A259SIS_DES=a
},v2z:function(a){gx.O.Z259SIS_DES=a},v2c:function(){gx.fn.setGridControlValue("SIS_DES",gx.fn.currentGridRowImpl(22),gx.O.A259SIS_DES,1)},c2v:function(){gx.O.A259SIS_DES=this.val()},val:function(){return gx.fn.getGridControlValue("SIS_DES",gx.fn.currentGridRowImpl(22))},nac:function(){return false}};this.GXValidFnc[27]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:22,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vICONO",gxz:"ZV16ICONO",gxold:"OV16ICONO",gxvar:"AV16ICONO",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV16ICONO=a
},v2z:function(a){gx.O.ZV16ICONO=a},v2c:function(){},c2v:function(){gx.O.AV16ICONO=this.val()},val:function(){return gx.fn.getGridControlValue("vICONO",gx.fn.currentGridRowImpl(22))},nac:function(){return false}};this.GXValidFnc[30]={fld:"TABLE4",grid:0};this.AV15SIS_COD=0;this.ZV15SIS_COD=0;this.OV15SIS_COD=0;this.AV5SISDES="";this.ZV5SISDES="";this.OV5SISDES="";this.ZV13Update="";this.OV13Update="";this.ZV14Delete="";this.OV14Delete="";this.Z116SIS_COD=0;this.O116SIS_COD=0;this.Z259SIS_DES="";this.O259SIS_DES="";
this.ZV16ICONO="";this.OV16ICONO="";this.AV8SISTEMA="";this.AV7USUARIO="";this.A123SIS_ICO="";this.AV13Update="";this.AV14Delete="";this.A116SIS_COD=0;this.A259SIS_DES="";this.AV16ICONO="";this.ServerEvents=["e114t2_client","e144t2_client","e154t2_client","e124t2_client","e184t2_client","e194t2_client"];this.VarControlMap.AV8SISTEMA={id:"vSISTEMA",grid:0,type:"char"};this.VarControlMap.AV7USUARIO={id:"vUSUARIO",grid:0,type:"char"};this.VarControlMap.A123SIS_ICO={id:"SIS_ICO",grid:0,type:"char"};this.Grid1Container.addRefreshingVar(this.GXValidFnc[10]);
this.Grid1Container.addRefreshingVar(this.GXValidFnc[15]);this.Grid1Container.addRefreshingVar({rfrVar:"AV14Delete",rfrProp:"Tooltiptext"});this.Grid1Container.addRefreshingVar({rfrVar:"AV14Delete",rfrProp:"Value"});this.Grid1Container.addRefreshingVar({rfrVar:"AV13Update",rfrProp:"Tooltiptext"});this.Grid1Container.addRefreshingVar({rfrVar:"AV13Update",rfrProp:"Value"});this.Grid1Container.addRefreshingVar({rfrVar:"A123SIS_ICO"});this.SetStandaloneVars()}hseg100.prototype=new gx.GxObject;gx.setParentObj(new hseg100());