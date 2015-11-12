/*
               File: Gx0260
        Description: Gx0260
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 12/17/2013 16:18:2.5
       Program type: Callable routine
          Main DBMS: sqlserver
*/
gx.evt.autoSkip = false;
function gx0260() {
   this.ServerClass =  "Gx0260" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.hasEnterEvent = false;
   this.autoRefresh = true;
   this.SetStandaloneVars=function()
   {
   };
   this.e12222_client=function()
   {
      this.executeServerEvent("ENTER", true);
   };
   this.e13222_client=function()
   {
      this.executeServerEvent("CANCEL", true);
   };
   this.GXValidFnc = [];
   this.GXLastCtrlId =0;
   this.ServerEvents = ["e12222_client" ,"e13222_client"];
   this.SetStandaloneVars( );
}
gx0260.prototype = new gx.GxObject;
gx.setParentObj(new gx0260());
