gx.evt.autoSkip=false;function wwgestores(){this.ServerClass="WWGESTORES";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=false;this.autoRefresh=true;this.SetStandaloneVars=function(){};this.Valid_Gestorcod=function(){try{if(gx.fn.currentGridRowImpl(24)===0){return true}var a=gx.util.balloon.getNew("GESTORCOD",gx.fn.currentGridRowImpl(24));this.AnyError=0;this.StandaloneModal();this.StandaloneNotModal()}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true
};this.e110v2_client=function(){this.executeServerEvent("'DOINSERT'",true,arguments[0])};this.e150v2_client=function(){this.executeServerEvent("ENTER",true,arguments[0])};this.e160v2_client=function(){this.executeServerEvent("CANCEL",true,arguments[0])};this.GXValidFnc=[];this.GXCtrlIds=[2,5,10,17,21,25,26,27,28];this.GXLastCtrlId=28;this.GridContainer=new gx.grid.grid(this,2,"WbpLvl2",24,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"wwgestores",[],false,1,false,true,0,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");
this.GridContainer.addBitmap("&Update","vUPDATE",25,0,"px",17,"px",null,"","");this.GridContainer.addBitmap("&Delete","vDELETE",26,0,"px",17,"px",null,"","");this.GridContainer.addSingleLineEdit(260,27,"GESTORCOD","Cod Gestor ","","GestorCod","char",0,"px",15,15,"left",null,[],260,"GestorCod",true,0,false,false);this.GridContainer.addSingleLineEdit(269,28,"GESTORDES","Gestor","","GestorDes","char",0,"px",50,50,"left",null,[],269,"GestorDes",true,0,false,false);this.setGrid(this.GridContainer);this.GXValidFnc[2]={fld:"TABLE",grid:0};
this.GXValidFnc[5]={fld:"TABLESEARCH",grid:0};this.GXValidFnc[8]={fld:"FILTERTEXTGESTORDES",format:0,grid:0};this.GXValidFnc[10]={lvl:0,type:"char",len:50,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vGESTORDES",gxz:"ZV13GestorDes",gxold:"OV13GestorDes",gxvar:"AV13GestorDes",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV13GestorDes=a},v2z:function(a){gx.O.ZV13GestorDes=a},v2c:function(){gx.fn.setControlValue("vGESTORDES",gx.O.AV13GestorDes,0)},c2v:function(){gx.O.AV13GestorDes=this.val()
},val:function(){return gx.fn.getControlValue("vGESTORDES")},nac:function(){return false}};this.GXValidFnc[13]={fld:"TABLESEPARATOR",format:0,grid:0};this.GXValidFnc[14]={fld:"SETEO",format:1,grid:0};this.GXValidFnc[17]={fld:"TABLEGRIDCONTAINER",grid:0};this.GXValidFnc[21]={fld:"INSERT",grid:0};this.GXValidFnc[25]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:24,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"vUPDATE",gxz:"ZV14Update",gxold:"OV14Update",gxvar:"AV14Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV14Update=a
},v2z:function(a){gx.O.ZV14Update=a},v2c:function(){},c2v:function(){gx.O.AV14Update=this.val()},val:function(){return gx.fn.getGridControlValue("vUPDATE",gx.fn.currentGridRowImpl(24))},nac:function(){return false}};this.GXValidFnc[26]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:24,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"vDELETE",gxz:"ZV15Delete",gxold:"OV15Delete",gxvar:"AV15Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV15Delete=a},v2z:function(a){gx.O.ZV15Delete=a
},v2c:function(){},c2v:function(){gx.O.AV15Delete=this.val()},val:function(){return gx.fn.getGridControlValue("vDELETE",gx.fn.currentGridRowImpl(24))},nac:function(){return false}};this.GXValidFnc[27]={lvl:2,type:"char",len:15,dec:0,sign:false,ro:1,grid:24,gxgrid:this.GridContainer,fnc:this.Valid_Gestorcod,isvalid:null,fld:"GESTORCOD",gxz:"Z260GestorCod",gxold:"O260GestorCod",gxvar:"A260GestorCod",ucs:[],op:[28],ip:[28,27],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A260GestorCod=a},v2z:function(a){gx.O.Z260GestorCod=a
},v2c:function(){gx.fn.setGridControlValue("GESTORCOD",gx.fn.currentGridRowImpl(24),gx.O.A260GestorCod,0)},c2v:function(){gx.O.A260GestorCod=this.val()},val:function(){return gx.fn.getGridControlValue("GESTORCOD",gx.fn.currentGridRowImpl(24))},nac:function(){return false}};this.GXValidFnc[28]={lvl:2,type:"char",len:50,dec:0,sign:false,ro:1,grid:24,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"GESTORDES",gxz:"Z269GestorDes",gxold:"O269GestorDes",gxvar:"A269GestorDes",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A269GestorDes=a
},v2z:function(a){gx.O.Z269GestorDes=a},v2c:function(){gx.fn.setGridControlValue("GESTORDES",gx.fn.currentGridRowImpl(24),gx.O.A269GestorDes,0)},c2v:function(){gx.O.A269GestorDes=this.val()},val:function(){return gx.fn.getGridControlValue("GESTORDES",gx.fn.currentGridRowImpl(24))},nac:function(){return false}};this.AV13GestorDes="";this.ZV13GestorDes="";this.OV13GestorDes="";this.ZV14Update="";this.OV14Update="";this.ZV15Delete="";this.OV15Delete="";this.Z260GestorCod="";this.O260GestorCod="";this.Z269GestorDes="";
this.O269GestorDes="";this.AV14Update="";this.AV15Delete="";this.A260GestorCod="";this.A269GestorDes="";this.ServerEvents=["e110v2_client","e150v2_client","e160v2_client"];this.GridContainer.addRefreshingVar(this.GXValidFnc[10]);this.GridContainer.addRefreshingVar({rfrVar:"AV15Delete",rfrProp:"Tooltiptext"});this.GridContainer.addRefreshingVar({rfrVar:"AV15Delete",rfrProp:"Value"});this.GridContainer.addRefreshingVar({rfrVar:"AV14Update",rfrProp:"Tooltiptext"});this.GridContainer.addRefreshingVar({rfrVar:"AV14Update",rfrProp:"Value"});
this.SetStandaloneVars()}wwgestores.prototype=new gx.GxObject;gx.setParentObj(new wwgestores());