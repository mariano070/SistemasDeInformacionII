gx.evt.autoSkip=false;function wwtseg006(){this.ServerClass="WWTSEG006";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=false;this.autoRefresh=true;this.SetStandaloneVars=function(){};this.Valid_Usu_cod=function(){try{if(gx.fn.currentGridRowImpl(26)===0){return true}var a=gx.util.balloon.getNew("USU_COD",gx.fn.currentGridRowImpl(26));this.AnyError=0;this.StandaloneModal();this.StandaloneNotModal()}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true
};this.Valid_Sis_cod=function(){try{if(gx.fn.currentGridRowImpl(26)===0){return true}var a=gx.util.balloon.getNew("SIS_COD",gx.fn.currentGridRowImpl(26));this.AnyError=0}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Prg_cod=function(){try{if(gx.fn.currentGridRowImpl(26)===0){return true}var a=gx.util.balloon.getNew("PRG_COD",gx.fn.currentGridRowImpl(26));this.AnyError=0}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.e11392_client=function(){this.executeServerEvent("'DOINSERT'",true,arguments[0])
};this.e15392_client=function(){this.executeServerEvent("ENTER",true,arguments[0])};this.e16392_client=function(){this.executeServerEvent("CANCEL",true,arguments[0])};this.GXValidFnc=[];this.GXCtrlIds=[2,8,13,19,23,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43];this.GXLastCtrlId=43;this.GridContainer=new gx.grid.grid(this,2,"WbpLvl2",26,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"wwtseg006",[],false,1,false,true,0,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");
this.GridContainer.addBitmap("&Update","vUPDATE",27,0,"px",17,"px",null,"","");this.GridContainer.addBitmap("&Delete","vDELETE",28,0,"px",17,"px",null,"","");this.GridContainer.addSingleLineEdit(6,29,"USU_COD","CODIGO","","USU_COD","char",0,"px",16,16,"left",null,[],6,"USU_COD",true,0,false,false);this.GridContainer.addSingleLineEdit(7,30,"USU_DES","DESCRIPCION","","USU_DES","char",0,"px",50,50,"left",null,[],7,"USU_DES",true,0,false,false);this.GridContainer.addSingleLineEdit(155,31,"USU_CLA","CONTRASEÑA","","USU_CLA","char",0,"px",20,20,"left",null,[],155,"USU_CLA",false,0,false,true);
this.GridContainer.addSingleLineEdit(116,32,"SIS_COD","CODIGO","","SIS_COD","int",0,"px",3,3,"right",null,[],116,"SIS_COD",true,0,false,false);this.GridContainer.addSingleLineEdit(259,33,"SIS_DES","DESCRIPCION","","SIS_DES","char",0,"px",15,15,"left",null,[],259,"SIS_DES",true,0,false,false);this.GridContainer.addSingleLineEdit(126,34,"PRG_COD","CODIGO","","PRG_COD","int",0,"px",4,4,"right",null,[],126,"PRG_COD",true,0,false,false);this.GridContainer.addSingleLineEdit(127,35,"PRG_DES","DESCRIPCION","","PRG_DES","char",0,"px",30,30,"left",null,[],127,"PRG_DES",true,0,false,false);
this.GridContainer.addSingleLineEdit(289,36,"PRG_NFI","NOMBRE FISICO","","PRG_NFI","char",0,"px",8,8,"left",null,[],289,"PRG_NFI",true,0,false,false);this.GridContainer.addSingleLineEdit(290,37,"USU_CNT","CONEXION DE USUARIO","","USU_CNT","char",0,"px",1,1,"left",null,[],290,"USU_CNT",true,0,false,false);this.GridContainer.addSingleLineEdit(118,38,"PRS_NRO","NRO DE SESION ASIGNADA","","PRS_NRO","int",0,"px",8,8,"right",null,[],118,"PRS_NRO",true,0,false,false);this.GridContainer.addSingleLineEdit(166,39,"PRS_INI","MOMENTO DE INICIO SESION","","PRS_INI","dtime",0,"px",14,8,"right",null,[],166,"PRS_INI",true,5,false,false);
this.GridContainer.addSingleLineEdit(404,40,"PRS_UOB","ULTIMO OBJETO","","PRS_UOB","char",0,"px",20,20,"left",null,[],404,"PRS_UOB",true,0,false,false);this.GridContainer.addSingleLineEdit(165,41,"PRS_CAD","MOMENTO CADUCIDAD SESION","","PRS_CAD","dtime",0,"px",14,8,"right",null,[],165,"PRS_CAD",true,5,false,false);this.GridContainer.addSingleLineEdit(405,42,"PRS_UDE","DESCRIPCION ULTIMO OBJETO","","PRS_UDE","char",0,"px",30,30,"left",null,[],405,"PRS_UDE",true,0,false,false);this.GridContainer.addSingleLineEdit(406,43,"PRS_ULNK","ULTIMO LINK","","PRS_ULNK","vchar",0,"px",300,300,"left",null,[],406,"PRS_ULNK",true,0,false,false);
this.setGrid(this.GridContainer);this.GXValidFnc[2]={fld:"TABLE",grid:0};this.GXValidFnc[5]={fld:"TITLETEXT",format:0,grid:0};this.GXValidFnc[8]={fld:"TABLESEARCH",grid:0};this.GXValidFnc[11]={fld:"FILTERTEXTPRS_INI",format:0,grid:0};this.GXValidFnc[13]={lvl:0,type:"dtime",len:8,dec:5,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vPRS_INI",gxz:"ZV13PRS_INI",gxold:"OV13PRS_INI",gxvar:"AV13PRS_INI",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/99 99:99",dec:5},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV13PRS_INI=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.ZV13PRS_INI=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setControlValue("vPRS_INI",gx.O.AV13PRS_INI,0)},c2v:function(){gx.O.AV13PRS_INI=this.val()},val:function(){return gx.fn.getControlValue("vPRS_INI")},nac:function(){return false}};this.GXValidFnc[16]={fld:"TABLESEPARATOR",format:0,grid:0};this.GXValidFnc[19]={fld:"TABLEGRIDCONTAINER",grid:0};this.GXValidFnc[23]={fld:"INSERT",grid:0};this.GXValidFnc[27]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"vUPDATE",gxz:"ZV14Update",gxold:"OV14Update",gxvar:"AV14Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV14Update=a
},v2z:function(a){gx.O.ZV14Update=a},v2c:function(){},c2v:function(){gx.O.AV14Update=this.val()},val:function(){return gx.fn.getGridControlValue("vUPDATE",gx.fn.currentGridRowImpl(26))},nac:function(){return false}};this.GXValidFnc[28]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"vDELETE",gxz:"ZV15Delete",gxold:"OV15Delete",gxvar:"AV15Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV15Delete=a},v2z:function(a){gx.O.ZV15Delete=a
},v2c:function(){},c2v:function(){gx.O.AV15Delete=this.val()},val:function(){return gx.fn.getGridControlValue("vDELETE",gx.fn.currentGridRowImpl(26))},nac:function(){return false}};this.GXValidFnc[29]={lvl:2,type:"char",len:16,dec:0,sign:false,ro:1,grid:26,gxgrid:this.GridContainer,fnc:this.Valid_Usu_cod,isvalid:null,fld:"USU_COD",gxz:"Z6USU_COD",gxold:"O6USU_COD",gxvar:"A6USU_COD",ucs:[],op:[37,30,31,33,35,36],ip:[37,30,31,33,35,36,29,32,34],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A6USU_COD=a
},v2z:function(a){gx.O.Z6USU_COD=a},v2c:function(){gx.fn.setGridControlValue("USU_COD",gx.fn.currentGridRowImpl(26),gx.O.A6USU_COD,0)},c2v:function(){gx.O.A6USU_COD=this.val()},val:function(){return gx.fn.getGridControlValue("USU_COD",gx.fn.currentGridRowImpl(26))},nac:function(){return false}};this.GXValidFnc[30]={lvl:2,type:"char",len:50,dec:0,sign:false,ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"USU_DES",gxz:"Z7USU_DES",gxold:"O7USU_DES",gxvar:"A7USU_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A7USU_DES=a
},v2z:function(a){gx.O.Z7USU_DES=a},v2c:function(){gx.fn.setGridControlValue("USU_DES",gx.fn.currentGridRowImpl(26),gx.O.A7USU_DES,0)},c2v:function(){gx.O.A7USU_DES=this.val()},val:function(){return gx.fn.getGridControlValue("USU_DES",gx.fn.currentGridRowImpl(26))},nac:function(){return false}};this.GXValidFnc[31]={lvl:2,type:"char",len:20,dec:0,sign:false,isPwd:true,ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"USU_CLA",gxz:"Z155USU_CLA",gxold:"O155USU_CLA",gxvar:"A155USU_CLA",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A155USU_CLA=a
},v2z:function(a){gx.O.Z155USU_CLA=a},v2c:function(){gx.fn.setGridControlValue("USU_CLA",gx.fn.currentGridRowImpl(26),gx.O.A155USU_CLA,0)},c2v:function(){gx.O.A155USU_CLA=this.val()},val:function(){return gx.fn.getGridControlValue("USU_CLA",gx.fn.currentGridRowImpl(26))},nac:function(){return false}};this.GXValidFnc[32]={lvl:2,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:1,grid:26,gxgrid:this.GridContainer,fnc:this.Valid_Sis_cod,isvalid:null,rgrid:[],fld:"SIS_COD",gxz:"Z116SIS_COD",gxold:"O116SIS_COD",gxvar:"A116SIS_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A116SIS_COD=gx.num.intval(a)
},v2z:function(a){gx.O.Z116SIS_COD=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("SIS_COD",gx.fn.currentGridRowImpl(26),gx.O.A116SIS_COD,0)},c2v:function(){gx.O.A116SIS_COD=this.val()},val:function(){return gx.fn.getGridIntegerValue("SIS_COD",gx.fn.currentGridRowImpl(26),".")},nac:function(){return false}};this.GXValidFnc[33]={lvl:2,type:"char",len:15,dec:0,sign:false,ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"SIS_DES",gxz:"Z259SIS_DES",gxold:"O259SIS_DES",gxvar:"A259SIS_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A259SIS_DES=a
},v2z:function(a){gx.O.Z259SIS_DES=a},v2c:function(){gx.fn.setGridControlValue("SIS_DES",gx.fn.currentGridRowImpl(26),gx.O.A259SIS_DES,0)},c2v:function(){gx.O.A259SIS_DES=this.val()},val:function(){return gx.fn.getGridControlValue("SIS_DES",gx.fn.currentGridRowImpl(26))},nac:function(){return false}};this.GXValidFnc[34]={lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:26,gxgrid:this.GridContainer,fnc:this.Valid_Prg_cod,isvalid:null,rgrid:[],fld:"PRG_COD",gxz:"Z126PRG_COD",gxold:"O126PRG_COD",gxvar:"A126PRG_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A126PRG_COD=gx.num.intval(a)
},v2z:function(a){gx.O.Z126PRG_COD=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("PRG_COD",gx.fn.currentGridRowImpl(26),gx.O.A126PRG_COD,0)},c2v:function(){gx.O.A126PRG_COD=this.val()},val:function(){return gx.fn.getGridIntegerValue("PRG_COD",gx.fn.currentGridRowImpl(26),".")},nac:function(){return false}};this.GXValidFnc[35]={lvl:2,type:"char",len:30,dec:0,sign:false,ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"PRG_DES",gxz:"Z127PRG_DES",gxold:"O127PRG_DES",gxvar:"A127PRG_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A127PRG_DES=a
},v2z:function(a){gx.O.Z127PRG_DES=a},v2c:function(){gx.fn.setGridControlValue("PRG_DES",gx.fn.currentGridRowImpl(26),gx.O.A127PRG_DES,0)},c2v:function(){gx.O.A127PRG_DES=this.val()},val:function(){return gx.fn.getGridControlValue("PRG_DES",gx.fn.currentGridRowImpl(26))},nac:function(){return false}};this.GXValidFnc[36]={lvl:2,type:"char",len:8,dec:0,sign:false,ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"PRG_NFI",gxz:"Z289PRG_NFI",gxold:"O289PRG_NFI",gxvar:"A289PRG_NFI",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A289PRG_NFI=a
},v2z:function(a){gx.O.Z289PRG_NFI=a},v2c:function(){gx.fn.setGridControlValue("PRG_NFI",gx.fn.currentGridRowImpl(26),gx.O.A289PRG_NFI,0)},c2v:function(){gx.O.A289PRG_NFI=this.val()},val:function(){return gx.fn.getGridControlValue("PRG_NFI",gx.fn.currentGridRowImpl(26))},nac:function(){return false}};this.GXValidFnc[37]={lvl:2,type:"char",len:1,dec:0,sign:false,ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"USU_CNT",gxz:"Z290USU_CNT",gxold:"O290USU_CNT",gxvar:"A290USU_CNT",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A290USU_CNT=a
},v2z:function(a){gx.O.Z290USU_CNT=a},v2c:function(){gx.fn.setGridControlValue("USU_CNT",gx.fn.currentGridRowImpl(26),gx.O.A290USU_CNT,0)},c2v:function(){gx.O.A290USU_CNT=this.val()},val:function(){return gx.fn.getGridControlValue("USU_CNT",gx.fn.currentGridRowImpl(26))},nac:function(){return false}};this.GXValidFnc[38]={lvl:2,type:"int",len:8,dec:0,sign:false,pic:"ZZZZZZZ9",ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"PRS_NRO",gxz:"Z118PRS_NRO",gxold:"O118PRS_NRO",gxvar:"A118PRS_NRO",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A118PRS_NRO=gx.num.intval(a)
},v2z:function(a){gx.O.Z118PRS_NRO=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("PRS_NRO",gx.fn.currentGridRowImpl(26),gx.O.A118PRS_NRO,0)},c2v:function(){gx.O.A118PRS_NRO=this.val()},val:function(){return gx.fn.getGridIntegerValue("PRS_NRO",gx.fn.currentGridRowImpl(26),".")},nac:function(){return false}};this.GXValidFnc[39]={lvl:2,type:"dtime",len:8,dec:5,sign:false,ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"PRS_INI",gxz:"Z166PRS_INI",gxold:"O166PRS_INI",gxvar:"A166PRS_INI",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/99 99:99",dec:5},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A166PRS_INI=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.Z166PRS_INI=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setGridControlValue("PRS_INI",gx.fn.currentGridRowImpl(26),gx.O.A166PRS_INI,0)},c2v:function(){gx.O.A166PRS_INI=this.val()},val:function(){return gx.fn.getGridControlValue("PRS_INI",gx.fn.currentGridRowImpl(26))},nac:function(){return false}};this.GXValidFnc[40]={lvl:2,type:"char",len:20,dec:0,sign:false,ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"PRS_UOB",gxz:"Z404PRS_UOB",gxold:"O404PRS_UOB",gxvar:"A404PRS_UOB",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A404PRS_UOB=a
},v2z:function(a){gx.O.Z404PRS_UOB=a},v2c:function(){gx.fn.setGridControlValue("PRS_UOB",gx.fn.currentGridRowImpl(26),gx.O.A404PRS_UOB,0)},c2v:function(){gx.O.A404PRS_UOB=this.val()},val:function(){return gx.fn.getGridControlValue("PRS_UOB",gx.fn.currentGridRowImpl(26))},nac:function(){return false}};this.GXValidFnc[41]={lvl:2,type:"dtime",len:8,dec:5,sign:false,ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"PRS_CAD",gxz:"Z165PRS_CAD",gxold:"O165PRS_CAD",gxvar:"A165PRS_CAD",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/99 99:99",dec:5},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A165PRS_CAD=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.Z165PRS_CAD=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setGridControlValue("PRS_CAD",gx.fn.currentGridRowImpl(26),gx.O.A165PRS_CAD,0)},c2v:function(){gx.O.A165PRS_CAD=this.val()},val:function(){return gx.fn.getGridControlValue("PRS_CAD",gx.fn.currentGridRowImpl(26))},nac:function(){return false}};this.GXValidFnc[42]={lvl:2,type:"char",len:30,dec:0,sign:false,ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"PRS_UDE",gxz:"Z405PRS_UDE",gxold:"O405PRS_UDE",gxvar:"A405PRS_UDE",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A405PRS_UDE=a
},v2z:function(a){gx.O.Z405PRS_UDE=a},v2c:function(){gx.fn.setGridControlValue("PRS_UDE",gx.fn.currentGridRowImpl(26),gx.O.A405PRS_UDE,0)},c2v:function(){gx.O.A405PRS_UDE=this.val()},val:function(){return gx.fn.getGridControlValue("PRS_UDE",gx.fn.currentGridRowImpl(26))},nac:function(){return false}};this.GXValidFnc[43]={lvl:2,type:"vchar",len:300,dec:0,sign:false,ro:1,grid:26,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"PRS_ULNK",gxz:"Z406PRS_ULNK",gxold:"O406PRS_ULNK",gxvar:"A406PRS_ULNK",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A406PRS_ULNK=a
},v2z:function(a){gx.O.Z406PRS_ULNK=a},v2c:function(){gx.fn.setGridControlValue("PRS_ULNK",gx.fn.currentGridRowImpl(26),gx.O.A406PRS_ULNK,0)},c2v:function(){gx.O.A406PRS_ULNK=this.val()},val:function(){return gx.fn.getGridControlValue("PRS_ULNK",gx.fn.currentGridRowImpl(26))},nac:function(){return false}};this.AV13PRS_INI=gx.date.nullDate();this.ZV13PRS_INI=gx.date.nullDate();this.OV13PRS_INI=gx.date.nullDate();this.ZV14Update="";this.OV14Update="";this.ZV15Delete="";this.OV15Delete="";this.Z6USU_COD="";
this.O6USU_COD="";this.Z7USU_DES="";this.O7USU_DES="";this.Z155USU_CLA="";this.O155USU_CLA="";this.Z116SIS_COD=0;this.O116SIS_COD=0;this.Z259SIS_DES="";this.O259SIS_DES="";this.Z126PRG_COD=0;this.O126PRG_COD=0;this.Z127PRG_DES="";this.O127PRG_DES="";this.Z289PRG_NFI="";this.O289PRG_NFI="";this.Z290USU_CNT="";this.O290USU_CNT="";this.Z118PRS_NRO=0;this.O118PRS_NRO=0;this.Z166PRS_INI=gx.date.nullDate();this.O166PRS_INI=gx.date.nullDate();this.Z404PRS_UOB="";this.O404PRS_UOB="";this.Z165PRS_CAD=gx.date.nullDate();
this.O165PRS_CAD=gx.date.nullDate();this.Z405PRS_UDE="";this.O405PRS_UDE="";this.Z406PRS_ULNK="";this.O406PRS_ULNK="";this.AV14Update="";this.AV15Delete="";this.A6USU_COD="";this.A7USU_DES="";this.A155USU_CLA="";this.A116SIS_COD=0;this.A259SIS_DES="";this.A126PRG_COD=0;this.A127PRG_DES="";this.A289PRG_NFI="";this.A290USU_CNT="";this.A118PRS_NRO=0;this.A166PRS_INI=gx.date.nullDate();this.A404PRS_UOB="";this.A165PRS_CAD=gx.date.nullDate();this.A405PRS_UDE="";this.A406PRS_ULNK="";this.ServerEvents=["e11392_client","e15392_client","e16392_client"];
this.GridContainer.addRefreshingVar(this.GXValidFnc[13]);this.GridContainer.addRefreshingVar({rfrVar:"AV15Delete",rfrProp:"Tooltiptext"});this.GridContainer.addRefreshingVar({rfrVar:"AV15Delete",rfrProp:"Value"});this.GridContainer.addRefreshingVar({rfrVar:"AV14Update",rfrProp:"Tooltiptext"});this.GridContainer.addRefreshingVar({rfrVar:"AV14Update",rfrProp:"Value"});this.SetStandaloneVars()}wwtseg006.prototype=new gx.GxObject;gx.setParentObj(new wwtseg006());