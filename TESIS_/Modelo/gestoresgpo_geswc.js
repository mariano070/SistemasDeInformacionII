gx.evt.autoSkip=false;function gestoresgpo_geswc(a){this.ServerClass="GESTORESGPO_GESWC";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(a);this.ReadonlyForm=true;this.hasEnterEvent=false;this.autoRefresh=true;this.SetStandaloneVars=function(){};this.e110x2_client=function(){this.executeServerEvent("'DOINSERT'",true,arguments[0])};this.e140x2_client=function(){this.executeServerEvent("ENTER",true,arguments[0])};this.e150x2_client=function(){this.executeServerEvent("CANCEL",true,arguments[0])
};this.GXValidFnc=[];this.GXCtrlIds=[2,5,10,14,15,16,17,18,21];this.GXLastCtrlId=21;this.GridContainer=new gx.grid.grid(this,2,"WbpLvl2",13,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"gestoresgpo_geswc",[],false,1,false,true,0,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");this.GridContainer.addBitmap("&Update","vUPDATE",14,0,"px",17,"px",null,"","");this.GridContainer.addBitmap("&Delete","vDELETE",15,0,"px",17,"px",null,"","");this.GridContainer.addSingleLineEdit(271,16,"GRUPO_COD","Cod Grupo","","Grupo_Cod","int",0,"px",4,4,"right",null,[],271,"Grupo_Cod",true,0,false,false);
this.GridContainer.addSingleLineEdit(273,17,"GRUPO_DES","Grupo de Gestión","","Grupo_Des","char",0,"px",20,20,"left",null,[],273,"Grupo_Des",true,0,false,false);this.GridContainer.addSingleLineEdit(275,18,"GRUPO_TIP","Tipo (Int/Ext)","","Grupo_Tip","char",0,"px",1,1,"left",null,[],275,"Grupo_Tip",true,0,false,false);this.setGrid(this.GridContainer);this.GXValidFnc[2]={fld:"TABLE",grid:0};this.GXValidFnc[5]={fld:"TABLEGRIDCONTAINER",grid:0};this.GXValidFnc[9]={fld:"SETEO",format:1,grid:0};this.GXValidFnc[10]={fld:"INSERT",grid:0};
this.GXValidFnc[14]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:13,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"vUPDATE",gxz:"ZV12Update",gxold:"OV12Update",gxvar:"AV12Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(b){gx.O.AV12Update=b},v2z:function(b){gx.O.ZV12Update=b},v2c:function(){},c2v:function(){gx.O.AV12Update=this.val()},val:function(){return gx.fn.getGridControlValue("vUPDATE",gx.fn.currentGridRowImpl(13))},nac:function(){return false}};this.GXValidFnc[15]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:13,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"vDELETE",gxz:"ZV13Delete",gxold:"OV13Delete",gxvar:"AV13Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(b){gx.O.AV13Delete=b
},v2z:function(b){gx.O.ZV13Delete=b},v2c:function(){},c2v:function(){gx.O.AV13Delete=this.val()},val:function(){return gx.fn.getGridControlValue("vDELETE",gx.fn.currentGridRowImpl(13))},nac:function(){return false}};this.GXValidFnc[16]={lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:13,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"GRUPO_COD",gxz:"Z271Grupo_Cod",gxold:"O271Grupo_Cod",gxvar:"A271Grupo_Cod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(b){gx.O.A271Grupo_Cod=gx.num.intval(b)
},v2z:function(b){gx.O.Z271Grupo_Cod=gx.num.intval(b)},v2c:function(){gx.fn.setGridControlValue("GRUPO_COD",gx.fn.currentGridRowImpl(13),gx.O.A271Grupo_Cod,0)},c2v:function(){gx.O.A271Grupo_Cod=this.val()},val:function(){return gx.fn.getGridIntegerValue("GRUPO_COD",gx.fn.currentGridRowImpl(13),".")},nac:function(){return false}};this.GXValidFnc[17]={lvl:2,type:"char",len:20,dec:0,sign:false,ro:1,grid:13,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"GRUPO_DES",gxz:"Z273Grupo_Des",gxold:"O273Grupo_Des",gxvar:"A273Grupo_Des",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(b){gx.O.A273Grupo_Des=b
},v2z:function(b){gx.O.Z273Grupo_Des=b},v2c:function(){gx.fn.setGridControlValue("GRUPO_DES",gx.fn.currentGridRowImpl(13),gx.O.A273Grupo_Des,0)},c2v:function(){gx.O.A273Grupo_Des=this.val()},val:function(){return gx.fn.getGridControlValue("GRUPO_DES",gx.fn.currentGridRowImpl(13))},nac:function(){return false}};this.GXValidFnc[18]={lvl:2,type:"char",len:1,dec:0,sign:false,ro:1,grid:13,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"GRUPO_TIP",gxz:"Z275Grupo_Tip",gxold:"O275Grupo_Tip",gxvar:"A275Grupo_Tip",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(b){gx.O.A275Grupo_Tip=b
},v2z:function(b){gx.O.Z275Grupo_Tip=b},v2c:function(){gx.fn.setGridControlValue("GRUPO_TIP",gx.fn.currentGridRowImpl(13),gx.O.A275Grupo_Tip,0)},c2v:function(){gx.O.A275Grupo_Tip=this.val()},val:function(){return gx.fn.getGridControlValue("GRUPO_TIP",gx.fn.currentGridRowImpl(13))},nac:function(){return false}};this.GXValidFnc[21]={lvl:0,type:"char",len:15,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"GES_COD",gxz:"Z270Ges_Cod",gxold:"O270Ges_Cod",gxvar:"A270Ges_Cod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(b){gx.O.A270Ges_Cod=b
},v2z:function(b){gx.O.Z270Ges_Cod=b},v2c:function(){gx.fn.setControlValue("GES_COD",gx.O.A270Ges_Cod,0)},c2v:function(){gx.O.A270Ges_Cod=this.val()},val:function(){return gx.fn.getControlValue("GES_COD")},nac:function(){return false}};this.ZV12Update="";this.OV12Update="";this.ZV13Delete="";this.OV13Delete="";this.Z271Grupo_Cod=0;this.O271Grupo_Cod=0;this.Z273Grupo_Des="";this.O273Grupo_Des="";this.Z275Grupo_Tip="";this.O275Grupo_Tip="";this.A270Ges_Cod="";this.Z270Ges_Cod="";this.O270Ges_Cod="";
this.AV7Ges_Cod="";this.AV12Update="";this.AV13Delete="";this.A271Grupo_Cod=0;this.A273Grupo_Des="";this.A275Grupo_Tip="";this.ServerEvents=["e110x2_client","e140x2_client","e150x2_client"];this.VarControlMap.AV7Ges_Cod={id:"vGES_COD",grid:0,type:"char"};this.GridContainer.addRefreshingVar({rfrVar:"AV7Ges_Cod"});this.GridContainer.addRefreshingVar({rfrVar:"AV13Delete",rfrProp:"Tooltiptext"});this.GridContainer.addRefreshingVar({rfrVar:"AV13Delete",rfrProp:"Value"});this.GridContainer.addRefreshingVar({rfrVar:"AV12Update",rfrProp:"Tooltiptext"});
this.GridContainer.addRefreshingVar({rfrVar:"AV12Update",rfrProp:"Value"});this.SetStandaloneVars()};