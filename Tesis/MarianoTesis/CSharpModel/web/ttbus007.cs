/*
               File: TTBUS007
        Description: Administración de Responsables Trazabilidad
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:30:6.87
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class ttbus007 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      protected void INITENV( )
      {
         if ( GxWebError != 0 )
         {
            return  ;
         }
      }

      protected void INITTRN( )
      {
         initialize_properties( ) ;
         entryPointCalled = false ;
         gxfirstwebparm = GetNextPar( ) ;
         gxfirstwebparm_bkp = gxfirstwebparm ;
         gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm, "High") ;
         if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            dyncall( GetNextPar( )) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_6") == 0 )
         {
            A33TTBUS7_Pos = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_6( A33TTBUS7_Pos) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_7") == 0 )
         {
            A35TTBUS7_CodResp = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_7( A35TTBUS7_CodResp) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_9") == 0 )
         {
            A39TTBUS7_CodUsuario = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39TTBUS7_CodUsuario", A39TTBUS7_CodUsuario);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_9( A39TTBUS7_CodUsuario) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
         {
            setAjaxEventMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxfirstwebparm = GetNextPar( ) ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridttbus007_permisos") == 0 )
         {
            nRC_Gridttbus007_permisos = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            nGXsfl_60_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            sGXsfl_60_idx = GetNextPar( ) ;
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxnrGridttbus007_permisos_newrow( nRC_Gridttbus007_permisos, nGXsfl_60_idx, sGXsfl_60_idx) ;
            return  ;
         }
         else
         {
            if ( ! IsValidAjaxCall( false) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxfirstwebparm = gxfirstwebparm_bkp ;
         }
         if ( ! entryPointCalled )
         {
            AV9TTBUS3_Pos = (short)(NumberUtil.Val( gxfirstwebparm, ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9TTBUS3_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9TTBUS3_Pos), 3, 0)));
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               Gx_mode = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               AV7SISTEMA = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7SISTEMA", AV7SISTEMA);
               AV8USUARIO = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8USUARIO", AV8USUARIO);
            }
         }
         GXCCtl = "TTBUS7_RESPAUX_" + sGXsfl_60_idx ;
         chkTTBUS7_RespAux.Name = GXCCtl ;
         chkTTBUS7_RespAux.WebTags = "" ;
         chkTTBUS7_RespAux.Caption = "" ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkTTBUS7_RespAux_Internalname, "Caption", chkTTBUS7_RespAux.Caption);
         chkTTBUS7_RespAux.CheckedValue = "0" ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Administración de Responsables Trazabilidad", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtTTBUS7_Pos_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Modern");
      }

      public ttbus007( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ttbus007( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref short aP0_TTBUS3_Pos ,
                           ref String aP1_Gx_mode ,
                           ref String aP2_SISTEMA ,
                           ref String aP3_USUARIO )
      {
         this.AV9TTBUS3_Pos = aP0_TTBUS3_Pos;
         this.Gx_mode = aP1_Gx_mode;
         this.AV7SISTEMA = aP2_SISTEMA;
         this.AV8USUARIO = aP3_USUARIO;
         executePrivate();
         aP0_TTBUS3_Pos=this.AV9TTBUS3_Pos;
         aP1_Gx_mode=this.Gx_mode;
         aP2_SISTEMA=this.AV7SISTEMA;
         aP3_USUARIO=this.AV8USUARIO;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         chkTTBUS7_RespAux = new GXCheckbox();
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITENV( ) ;
         INITTRN( ) ;
         if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("mptrazabilidad", "GeneXus.Programs.mptrazabilidad", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            MasterPageObj.webExecute();
            if ( context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
               }
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) )
               {
                  context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               }
               else
               {
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      protected void Draw( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! GxWebStd.gx_redirect( context) )
         {
            disable_std_buttons( ) ;
            enableDisable( ) ;
            set_caption( ) ;
            /* Form start */
            wb_table1_2_067( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_067e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_067( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_067( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_067e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Administración de Responsables Trazabilidad"+"</legend>") ;
            wb_table3_27_067( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_067e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_067e( true) ;
         }
         else
         {
            wb_table1_2_067e( false) ;
         }
      }

      protected void wb_table3_27_067( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table4_33_067( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_067e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_enter_Internalname, "Confirmar", "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "rounded", 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "HLP_TTBUS007.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "HLP_TTBUS007.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_delete_Internalname, "Eliminar", "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 0, "rounded", 5, bttBtn_delete_Jsonclick, "EDELETE.", TempTags, "", "", "HLP_TTBUS007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_067e( true) ;
         }
         else
         {
            wb_table3_27_067e( false) ;
         }
      }

      protected void wb_table4_33_067( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus7_pos_Internalname, 1, 1, 0, "Id. de Posición", "", "", "", 0, lblTextblockttbus7_pos_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS7_Pos_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A33TTBUS7_Pos), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, edtTTBUS7_Pos_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A33TTBUS7_Pos), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(38);\"", 0, edtTTBUS7_Pos_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TTBUS007.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_33_Internalname, "", "prompt.gif", "Modern", imgprompt_33_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, imgprompt_33_Link, "", 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_TTBUS007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus7_des_Internalname, 1, 1, 0, "Descripción posición", "", "", "", 0, lblTextblockttbus7_des_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS7_Des_Internalname, StringUtil.RTrim( A34TTBUS7_Des), "", 50, "chr", 1, "row", 50, 1, edtTTBUS7_Des_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A34TTBUS7_Des, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), "", 0, edtTTBUS7_Des_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TTBUS007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus7_codresp_Internalname, 1, 1, 0, "Código Responsable", "", "", "", 0, lblTextblockttbus7_codresp_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS7_CodResp_Internalname, StringUtil.RTrim( A35TTBUS7_CodResp), "", 16, "chr", 1, "row", 16, 1, edtTTBUS7_CodResp_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A35TTBUS7_CodResp, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(48);\"", 0, edtTTBUS7_CodResp_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TTBUS007.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_35_Internalname, "", "prompt.gif", "Modern", imgprompt_35_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, imgprompt_35_Link, "", 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_TTBUS007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus7_desresp_Internalname, 1, 1, 0, "Descripción Responsable", "", "", "", 0, lblTextblockttbus7_desresp_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS7_DesResp_Internalname, StringUtil.RTrim( A36TTBUS7_DesResp), "", 50, "chr", 1, "row", 50, 1, edtTTBUS7_DesResp_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A36TTBUS7_DesResp, "@!")), "", 0, edtTTBUS7_DesResp_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TTBUS007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            context.WriteHtmlText( "<br>") ;
            wb_table5_56_067( true) ;
         }
         return  ;
      }

      protected void wb_table5_56_067e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "<hr class=\"HRDefault\">") ;
            /*  Grid Control  */
            Gridttbus007_permisosContainer.AddObjectProperty("GridName", "Gridttbus007_permisos");
            Gridttbus007_permisosContainer.AddObjectProperty("Class", "Grid");
            Gridttbus007_permisosContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
            Gridttbus007_permisosContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
            Gridttbus007_permisosContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridttbus007_permisos_Backcolorstyle), 1, 0, ".", "")));
            Gridttbus007_permisosContainer.AddObjectProperty("CmpContext", "");
            Gridttbus007_permisosContainer.AddObjectProperty("InMasterPage", "false");
            Gridttbus007_permisosColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridttbus007_permisosColumn.AddObjectProperty("Value", StringUtil.RTrim( A39TTBUS7_CodUsuario));
            Gridttbus007_permisosColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTTBUS7_CodUsuario_Enabled), 5, 0, ".", "")));
            Gridttbus007_permisosContainer.AddColumnProperties(Gridttbus007_permisosColumn);
            Gridttbus007_permisosColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridttbus007_permisosContainer.AddColumnProperties(Gridttbus007_permisosColumn);
            Gridttbus007_permisosColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridttbus007_permisosColumn.AddObjectProperty("Value", StringUtil.RTrim( A199TTBUS7_DesUsuario));
            Gridttbus007_permisosColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTTBUS7_DesUsuario_Enabled), 5, 0, ".", "")));
            Gridttbus007_permisosContainer.AddColumnProperties(Gridttbus007_permisosColumn);
            Gridttbus007_permisosColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridttbus007_permisosColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A51TTBUS7_RespAux), 1, 0, ".", "")));
            Gridttbus007_permisosColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkTTBUS7_RespAux.Enabled), 5, 0, ".", "")));
            Gridttbus007_permisosContainer.AddColumnProperties(Gridttbus007_permisosColumn);
            Gridttbus007_permisosContainer.AddObjectProperty("Allowselection", "false");
            Gridttbus007_permisosContainer.AddObjectProperty("Allowcollapsing", "false");
            Gridttbus007_permisosContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridttbus007_permisos_Collapsed), 9, 0, ".", "")));
            nGXsfl_60_idx = 0 ;
            if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
            {
               /* Enter key processing. */
               nBlankRcdCount8 = 5 ;
               if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
               {
                  /* Display confirmed (stored) records */
                  nRcdExists_8 = 1 ;
                  ScanStart068( ) ;
                  while ( RcdFound8 != 0 )
                  {
                     init_level_properties8( ) ;
                     getByPrimaryKey068( ) ;
                     AddRow068( ) ;
                     ScanNext068( ) ;
                  }
                  ScanEnd068( ) ;
                  nBlankRcdCount8 = 5 ;
               }
            }
            else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
            {
               /* Button check  or addlines. */
               standaloneNotModal068( ) ;
               standaloneModal068( ) ;
               sMode8 = Gx_mode ;
               while ( nGXsfl_60_idx < nRC_Gridttbus007_permisos )
               {
                  ReadRow068( ) ;
                  edtTTBUS7_CodUsuario_Enabled = (int)(context.localUtil.CToN( cgiGet( "TTBUS7_CODUSUARIO_"+sGXsfl_60_idx+"Enabled"), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS7_CodUsuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS7_CodUsuario_Enabled), 5, 0)));
                  edtTTBUS7_DesUsuario_Enabled = (int)(context.localUtil.CToN( cgiGet( "TTBUS7_DESUSUARIO_"+sGXsfl_60_idx+"Enabled"), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS7_DesUsuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS7_DesUsuario_Enabled), 5, 0)));
                  chkTTBUS7_RespAux.Enabled = (int)(context.localUtil.CToN( cgiGet( "TTBUS7_RESPAUX_"+sGXsfl_60_idx+"Enabled"), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkTTBUS7_RespAux_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkTTBUS7_RespAux.Enabled), 5, 0)));
                  imgprompt_33_Link = cgiGet( "PROMPT_39_"+sGXsfl_60_idx+"Link") ;
                  if ( ( nRcdExists_8 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     standaloneModal068( ) ;
                  }
                  SendRow068( ) ;
               }
               Gx_mode = sMode8 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            }
            else
            {
               /* Get or get-alike key processing. */
               nBlankRcdCount8 = 5 ;
               nRcdExists_8 = 1 ;
               ScanStart068( ) ;
               while ( RcdFound8 != 0 )
               {
                  init_level_properties8( ) ;
                  getByPrimaryKey068( ) ;
                  standaloneNotModal068( ) ;
                  standaloneModal068( ) ;
                  AddRow068( ) ;
                  ScanNext068( ) ;
               }
               ScanEnd068( ) ;
            }
            /* Initialize fields for 'new' records and send them. */
            if ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 )
            {
               sMode8 = Gx_mode ;
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               InitAll068( ) ;
               init_level_properties8( ) ;
               standaloneNotModal068( ) ;
               standaloneModal068( ) ;
               nRcdExists_8 = 0 ;
               nIsMod_8 = 0 ;
               nBlankRcdCount8 = (short)(nBlankRcdUsr8+nBlankRcdCount8) ;
               fRowAdded = 0 ;
               while ( nBlankRcdCount8 > 0 )
               {
                  AddRow068( ) ;
                  if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
                  {
                     fRowAdded = 1 ;
                     GX_FocusControl = edtTTBUS7_CodUsuario_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  nBlankRcdCount8 = (short)(nBlankRcdCount8-1) ;
               }
               Gx_mode = sMode8 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            }
            sStyleString = " style=\"display:none;\"" ;
            sStyleString = "" ;
            context.WriteHtmlText( "<div id=\""+"Gridttbus007_permisosContainer"+"Div\" "+sStyleString+">"+"</div>") ;
            context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridttbus007_permisos", (Object)(Gridttbus007_permisosContainer));
            GxWebStd.gx_hidden_field( context, "Gridttbus007_permisosContainerData", Gridttbus007_permisosContainer.ToJavascriptSource());
            if ( context.isAjaxRequest( ) )
            {
               GxWebStd.gx_hidden_field( context, "Gridttbus007_permisosContainerData"+"V", Gridttbus007_permisosContainer.GridValuesHidden());
            }
            else
            {
               context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridttbus007_permisosContainerData"+"V"+"\" value='"+Gridttbus007_permisosContainer.GridValuesHidden()+"'>") ;
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_067e( true) ;
         }
         else
         {
            wb_table4_33_067e( false) ;
         }
      }

      protected void wb_table5_56_067( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table95", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class=\"SubTitle\" >") ;
            /* Text block */
            ClassString = "" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTitlepermisos_Internalname, 1, 1, 0, "Permisos", "", "", "", 0, lblTitlepermisos_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS007.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_56_067e( true) ;
         }
         else
         {
            wb_table5_56_067e( false) ;
         }
      }

      protected void wb_table2_5_067( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTabletoolbar_Internalname, tblTabletoolbar_Internalname, "", "ViewTable", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "<div style=\"WHITE-SPACE: nowrap\" class=\"ToolbarMain\">") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 8,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, "", context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Modern"), "Modern", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS007.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS007.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, "", context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Modern"), "Modern", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS007.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS007.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, "", context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Modern"), "Modern", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS007.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS007.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, "", context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Modern"), "Modern", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS007.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS007.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, "", context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Modern"), "Modern", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00v0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"TTBUS7_POS"+"'), id:'"+"TTBUS7_POS"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");"+"return false;", "HLP_TTBUS007.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00v0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"TTBUS7_POS"+"'), id:'"+"TTBUS7_POS"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");"+"return false;", "HLP_TTBUS007.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, "", context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Modern"), "Modern", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS007.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS007.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, "", context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Modern"), "Modern", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS007.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS007.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, "", context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Modern"), "Modern", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS007.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS007.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_5_067e( true) ;
         }
         else
         {
            wb_table2_5_067e( false) ;
         }
      }

      protected void UserMain( )
      {
         standaloneStartup( ) ;
      }

      protected void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
         Process( ) ;
      }

      protected void standaloneStartupServer( )
      {
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         context.wbGlbDoneStart = 1 ;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( ! context.localUtil.VCNumber( cgiGet( edtTTBUS7_Pos_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtTTBUS7_Pos_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtTTBUS7_Pos_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "TTBUS7_POS");
                  AnyError = 1 ;
                  GX_FocusControl = edtTTBUS7_Pos_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A33TTBUS7_Pos = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
               }
               else
               {
                  A33TTBUS7_Pos = (short)(context.localUtil.CToN( cgiGet( edtTTBUS7_Pos_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
               }
               A34TTBUS7_Des = cgiGet( edtTTBUS7_Des_Internalname) ;
               n34TTBUS7_Des = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
               A35TTBUS7_CodResp = StringUtil.Upper( cgiGet( edtTTBUS7_CodResp_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
               A36TTBUS7_DesResp = StringUtil.Upper( cgiGet( edtTTBUS7_DesResp_Internalname)) ;
               n36TTBUS7_DesResp = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
               /* Read saved values. */
               Z33TTBUS7_Pos = (short)(context.localUtil.CToN( cgiGet( "Z33TTBUS7_Pos"), ",", ".")) ;
               Z35TTBUS7_CodResp = cgiGet( "Z35TTBUS7_CodResp") ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", ".")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", ".")) ;
               Gx_mode = cgiGet( "Mode") ;
               nRC_Gridttbus007_permisos = (short)(context.localUtil.CToN( cgiGet( "nRC_Gridttbus007_permisos"), ",", ".")) ;
               AV7SISTEMA = cgiGet( "vSISTEMA") ;
               AV8USUARIO = cgiGet( "vUSUARIO") ;
               AV9TTBUS3_Pos = (short)(context.localUtil.CToN( cgiGet( "vTTBUS3_POS"), ",", ".")) ;
               Gx_mode = cgiGet( "vMODE") ;
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  A33TTBUS7_Pos = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  disable_std_buttons( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
                  {
                     sMode7 = Gx_mode ;
                     Gx_mode = "UPD" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Gx_mode = sMode7 ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound7 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_060( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert"), 1, "TTBUS7_POS");
                        AnyError = 1 ;
                     }
                  }
               }
            }
         }
      }

      protected void Process( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read Transaction buttons. */
            sEvt = cgiGet( "_EventName") ;
            EvtGridId = cgiGet( "_EventGridId") ;
            EvtRowId = cgiGet( "_EventRowId") ;
            if ( StringUtil.Len( sEvt) > 0 )
            {
               sEvtType = StringUtil.Left( sEvt, 1) ;
               sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
               /* Check if conditions changed and reset current page numbers */
               if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
               {
                  if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                  {
                     sEvtType = StringUtil.Right( sEvt, 1) ;
                     if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                     {
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                        if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_enter( ) ;
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                        {
                           context.wbHandled = 1 ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "PREVIOUS") == 0 )
                        {
                           context.wbHandled = 1 ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                        {
                           context.wbHandled = 1 ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                        {
                           context.wbHandled = 1 ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "SELECT") == 0 )
                        {
                           context.wbHandled = 1 ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DELETE") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_delete( ) ;
                        }
                     }
                     else
                     {
                        sEvtType = StringUtil.Right( sEvt, 4) ;
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
                     }
                  }
                  context.wbHandled = 1 ;
               }
            }
         }
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            trnEnded = 0 ;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll067( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      protected void disable_std_buttons( )
      {
         imgBtn_delete2_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Visible), 5, 0)));
         imgBtn_delete2_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_separator_Visible), 5, 0)));
         bttBtn_delete_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
         imgBtn_first_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_first_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_first_Visible), 5, 0)));
         imgBtn_first_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_first_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_first_separator_Visible), 5, 0)));
         imgBtn_previous_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_previous_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_previous_Visible), 5, 0)));
         imgBtn_previous_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_previous_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_previous_separator_Visible), 5, 0)));
         imgBtn_next_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_next_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_next_Visible), 5, 0)));
         imgBtn_next_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_next_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_next_separator_Visible), 5, 0)));
         imgBtn_last_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_last_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_last_Visible), 5, 0)));
         imgBtn_last_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_last_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_last_separator_Visible), 5, 0)));
         imgBtn_select_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_select_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_select_Visible), 5, 0)));
         imgBtn_select_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_select_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_select_separator_Visible), 5, 0)));
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            imgBtn_delete2_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Visible), 5, 0)));
            imgBtn_delete2_separator_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_separator_Visible), 5, 0)));
            bttBtn_delete_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
            if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
            {
               imgBtn_enter2_Visible = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_enter2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_enter2_Visible), 5, 0)));
               imgBtn_enter2_separator_Visible = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_enter2_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_enter2_separator_Visible), 5, 0)));
               bttBtn_enter_Visible = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)));
            }
            edtTTBUS7_Pos_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS7_Pos_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS7_Pos_Enabled), 5, 0)));
            edtTTBUS7_Des_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS7_Des_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS7_Des_Enabled), 5, 0)));
            edtTTBUS7_CodResp_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS7_CodResp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS7_CodResp_Enabled), 5, 0)));
            edtTTBUS7_DesResp_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS7_DesResp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS7_DesResp_Enabled), 5, 0)));
            edtTTBUS7_CodUsuario_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS7_CodUsuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS7_CodUsuario_Enabled), 5, 0)));
            edtTTBUS7_DesUsuario_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS7_DesUsuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS7_DesUsuario_Enabled), 5, 0)));
            chkTTBUS7_RespAux.Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkTTBUS7_RespAux_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkTTBUS7_RespAux.Enabled), 5, 0)));
         }
      }

      protected void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_confdelete"), 0, "");
            }
            else
            {
               GX_msglist.addItem(context.GetMessage( "GXM_mustconfirm"), 0, "");
            }
         }
      }

      protected void CONFIRM_060( )
      {
         BeforeValidate067( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls067( ) ;
            }
            else
            {
               CheckExtendedTable067( ) ;
               CloseExtendedTableCursors067( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            /* Save parent mode. */
            sMode7 = Gx_mode ;
            CONFIRM_068( ) ;
            if ( AnyError == 0 )
            {
               /* Restore parent mode. */
               Gx_mode = sMode7 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               IsConfirmed = 1 ;
            }
            /* Restore parent mode. */
            Gx_mode = sMode7 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
      }

      protected void CONFIRM_068( )
      {
         nGXsfl_60_idx = 0 ;
         while ( nGXsfl_60_idx < nRC_Gridttbus007_permisos )
         {
            ReadRow068( ) ;
            if ( ( nRcdExists_8 != 0 ) || ( nIsMod_8 != 0 ) )
            {
               GetKey068( ) ;
               if ( ( nRcdExists_8 == 0 ) && ( nRcdDeleted_8 == 0 ) )
               {
                  if ( RcdFound8 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     BeforeValidate068( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable068( ) ;
                        CloseExtendedTableCursors068( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1 ;
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "");
                     AnyError = 1 ;
                     GX_FocusControl = edtTTBUS7_CodUsuario_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound8 != 0 )
                  {
                     if ( nRcdDeleted_8 != 0 )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        getByPrimaryKey068( ) ;
                        Load068( ) ;
                        BeforeValidate068( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls068( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_8 != 0 )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           BeforeValidate068( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable068( ) ;
                              CloseExtendedTableCursors068( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1 ;
                              }
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_8 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "");
                        AnyError = 1 ;
                        GX_FocusControl = edtTTBUS7_CodUsuario_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtTTBUS7_CodUsuario_Internalname, StringUtil.RTrim( A39TTBUS7_CodUsuario)) ;
            ChangePostValue( edtTTBUS7_DesUsuario_Internalname, StringUtil.RTrim( A199TTBUS7_DesUsuario)) ;
            ChangePostValue( chkTTBUS7_RespAux_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A51TTBUS7_RespAux), 1, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z39TTBUS7_CodUsuario_"+sGXsfl_60_idx, StringUtil.RTrim( Z39TTBUS7_CodUsuario)) ;
            ChangePostValue( "ZT_"+"Z51TTBUS7_RespAux_"+sGXsfl_60_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z51TTBUS7_RespAux), 1, 0, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_8_"+sGXsfl_60_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_8), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_8_"+sGXsfl_60_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_8), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_8_"+sGXsfl_60_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_8), 4, 0, ",", ""))) ;
            if ( nIsMod_8 != 0 )
            {
               ChangePostValue( "TTBUS7_CODUSUARIO_"+sGXsfl_60_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTTBUS7_CodUsuario_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "TTBUS7_DESUSUARIO_"+sGXsfl_60_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTTBUS7_DesUsuario_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "TTBUS7_RESPAUX_"+sGXsfl_60_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkTTBUS7_RespAux.Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption060( )
      {
      }

      protected void ZM067( short GX_JID )
      {
         if ( ( GX_JID == 5 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z35TTBUS7_CodResp = T00066_A35TTBUS7_CodResp[0] ;
            }
            else
            {
               Z35TTBUS7_CodResp = A35TTBUS7_CodResp ;
            }
         }
         if ( GX_JID == -5 )
         {
            Z33TTBUS7_Pos = A33TTBUS7_Pos ;
            Z35TTBUS7_CodResp = A35TTBUS7_CodResp ;
            Z34TTBUS7_Des = A34TTBUS7_Des ;
            Z36TTBUS7_DesResp = A36TTBUS7_DesResp ;
         }
      }

      protected void standaloneNotModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtTTBUS7_Pos_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS7_Pos_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS7_Pos_Enabled), 5, 0)));
         }
         else
         {
            edtTTBUS7_Pos_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS7_Pos_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS7_Pos_Enabled), 5, 0)));
         }
         imgprompt_33_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00v0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"TTBUS7_POS"+"'), id:'"+"TTBUS7_POS"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");") ;
         imgprompt_35_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00f0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"TTBUS7_CODRESP"+"'), id:'"+"TTBUS7_CODRESP"+"'"+",isOut:true,isKey:false,isLastKey:false}"+"],"+"null"+","+"'', false"+","+"false"+","+"false"+");") ;
         imgBtn_delete2_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            A33TTBUS7_Pos = AV9TTBUS3_Pos ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
         }
      }

      protected void standaloneModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtTTBUS7_Pos_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS7_Pos_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS7_Pos_Enabled), 5, 0)));
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            imgBtn_enter2_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_enter2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_enter2_Enabled), 5, 0)));
         }
         else
         {
            imgBtn_enter2_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_enter2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_enter2_Enabled), 5, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            /* Using cursor T00067 */
            pr_default.execute(5, new Object[] {A33TTBUS7_Pos});
            A34TTBUS7_Des = T00067_A34TTBUS7_Des[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
            n34TTBUS7_Des = T00067_n34TTBUS7_Des[0] ;
            pr_default.close(5);
         }
      }

      protected void Load067( )
      {
         /* Using cursor T00069 */
         pr_default.execute(7, new Object[] {A33TTBUS7_Pos});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound7 = 1 ;
            A34TTBUS7_Des = T00069_A34TTBUS7_Des[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
            n34TTBUS7_Des = T00069_n34TTBUS7_Des[0] ;
            A36TTBUS7_DesResp = T00069_A36TTBUS7_DesResp[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
            n36TTBUS7_DesResp = T00069_n36TTBUS7_DesResp[0] ;
            A35TTBUS7_CodResp = T00069_A35TTBUS7_CodResp[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
            ZM067( -5) ;
         }
         pr_default.close(7);
         OnLoadActions067( ) ;
      }

      protected void OnLoadActions067( )
      {
      }

      protected void CheckExtendedTable067( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T00067 */
         pr_default.execute(5, new Object[] {A33TTBUS7_Pos});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("No existe 'Posición Trazabilidad'.", "ForeignKeyNotFound", 1, "TTBUS7_POS");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS7_Pos_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A34TTBUS7_Des = T00067_A34TTBUS7_Des[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
            n34TTBUS7_Des = T00067_n34TTBUS7_Des[0] ;
         }
         pr_default.close(5);
         /* Using cursor T00068 */
         pr_default.execute(6, new Object[] {A35TTBUS7_CodResp});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("No existe 'Responsable de Posición'.", "ForeignKeyNotFound", 1, "TTBUS7_CODRESP");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS7_CodResp_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A36TTBUS7_DesResp = T00068_A36TTBUS7_DesResp[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
            n36TTBUS7_DesResp = T00068_n36TTBUS7_DesResp[0] ;
         }
         pr_default.close(6);
      }

      protected void CloseExtendedTableCursors067( )
      {
         pr_default.close(5);
         pr_default.close(6);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_6( short A33TTBUS7_Pos )
      {
         /* Using cursor T000610 */
         pr_default.execute(8, new Object[] {A33TTBUS7_Pos});
         if ( (pr_default.getStatus(8) == 101) )
         {
            GX_msglist.addItem("No existe 'Posición Trazabilidad'.", "ForeignKeyNotFound", 1, "TTBUS7_POS");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS7_Pos_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A34TTBUS7_Des = T000610_A34TTBUS7_Des[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
            n34TTBUS7_Des = T000610_n34TTBUS7_Des[0] ;
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A34TTBUS7_Des))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(8) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(8);
      }

      protected void gxLoad_7( String A35TTBUS7_CodResp )
      {
         /* Using cursor T000611 */
         pr_default.execute(9, new Object[] {A35TTBUS7_CodResp});
         if ( (pr_default.getStatus(9) == 101) )
         {
            GX_msglist.addItem("No existe 'Responsable de Posición'.", "ForeignKeyNotFound", 1, "TTBUS7_CODRESP");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS7_CodResp_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A36TTBUS7_DesResp = T000611_A36TTBUS7_DesResp[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
            n36TTBUS7_DesResp = T000611_n36TTBUS7_DesResp[0] ;
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A36TTBUS7_DesResp))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(9) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(9);
      }

      protected void GetKey067( )
      {
         /* Using cursor T000612 */
         pr_default.execute(10, new Object[] {A33TTBUS7_Pos});
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound7 = 1 ;
         }
         else
         {
            RcdFound7 = 0 ;
         }
         pr_default.close(10);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00066 */
         pr_default.execute(4, new Object[] {A33TTBUS7_Pos});
         if ( (pr_default.getStatus(4) != 101) )
         {
            ZM067( 5) ;
            RcdFound7 = 1 ;
            A33TTBUS7_Pos = T00066_A33TTBUS7_Pos[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
            A35TTBUS7_CodResp = T00066_A35TTBUS7_CodResp[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
            Z33TTBUS7_Pos = A33TTBUS7_Pos ;
            sMode7 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            Load067( ) ;
            Gx_mode = sMode7 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound7 = 0 ;
            InitializeNonKey067( ) ;
            sMode7 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode7 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(4);
      }

      protected void getEqualNoModal( )
      {
         GetKey067( ) ;
         if ( RcdFound7 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound7 = 0 ;
         /* Using cursor T000613 */
         pr_default.execute(11, new Object[] {A33TTBUS7_Pos});
         if ( (pr_default.getStatus(11) != 101) )
         {
            while ( (pr_default.getStatus(11) != 101) && ( ( T000613_A33TTBUS7_Pos[0] < A33TTBUS7_Pos ) ) )
            {
               pr_default.readNext(11);
            }
            if ( (pr_default.getStatus(11) != 101) && ( ( T000613_A33TTBUS7_Pos[0] > A33TTBUS7_Pos ) ) )
            {
               A33TTBUS7_Pos = T000613_A33TTBUS7_Pos[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
               RcdFound7 = 1 ;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound7 = 0 ;
         /* Using cursor T000614 */
         pr_default.execute(12, new Object[] {A33TTBUS7_Pos});
         if ( (pr_default.getStatus(12) != 101) )
         {
            while ( (pr_default.getStatus(12) != 101) && ( ( T000614_A33TTBUS7_Pos[0] > A33TTBUS7_Pos ) ) )
            {
               pr_default.readNext(12);
            }
            if ( (pr_default.getStatus(12) != 101) && ( ( T000614_A33TTBUS7_Pos[0] < A33TTBUS7_Pos ) ) )
            {
               A33TTBUS7_Pos = T000614_A33TTBUS7_Pos[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
               RcdFound7 = 1 ;
            }
         }
         pr_default.close(3);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey067( ) ;
         if ( RcdFound7 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "TTBUS7_POS");
               AnyError = 1 ;
               GX_FocusControl = edtTTBUS7_Pos_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( A33TTBUS7_Pos != Z33TTBUS7_Pos )
            {
               A33TTBUS7_Pos = Z33TTBUS7_Pos ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "CandidateKeyNotFound", 1, "TTBUS7_POS");
               AnyError = 1 ;
               GX_FocusControl = edtTTBUS7_Pos_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtTTBUS7_Pos_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               /* Update record */
               Update067( ) ;
               GX_FocusControl = edtTTBUS7_Pos_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( A33TTBUS7_Pos != Z33TTBUS7_Pos )
            {
               /* Insert record */
               Insert067( ) ;
               GX_FocusControl = edtTTBUS7_Pos_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "TTBUS7_POS");
                  AnyError = 1 ;
                  GX_FocusControl = edtTTBUS7_Pos_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Insert record */
                  Insert067( ) ;
                  GX_FocusControl = edtTTBUS7_Pos_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
         }
         AfterTrn( ) ;
         if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            if ( AnyError == 0 )
            {
               context.nUserReturn = 1 ;
            }
         }
      }

      protected void btn_delete( )
      {
         if ( A33TTBUS7_Pos != Z33TTBUS7_Pos )
         {
            A33TTBUS7_Pos = Z33TTBUS7_Pos ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt"), 1, "TTBUS7_POS");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS7_Pos_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtTTBUS7_Pos_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency067( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000615 */
            pr_default.execute(13, new Object[] {A33TTBUS7_Pos});
            if ( (pr_default.getStatus(13) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TTBUS007"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(13) == 101) || ( StringUtil.StrCmp(Z35TTBUS7_CodResp, T000615_A35TTBUS7_CodResp[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"TTBUS007"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert067( )
      {
         BeforeValidate067( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable067( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM067( 0) ;
            CheckOptimisticConcurrency067( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm067( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert067( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000616 */
                     pr_default.execute(14, new Object[] {A33TTBUS7_Pos, A35TTBUS7_CodResp});
                     pr_default.close(14);
                     if ( (pr_default.getStatus(14) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1 ;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel067( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded"), 0, "");
                              ResetCaption060( ) ;
                           }
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                     AnyError = 1 ;
                  }
               }
            }
            else
            {
               Load067( ) ;
            }
            EndLevel067( ) ;
         }
         CloseExtendedTableCursors067( ) ;
      }

      protected void Update067( )
      {
         BeforeValidate067( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable067( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency067( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm067( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate067( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000617 */
                     pr_default.execute(15, new Object[] {A35TTBUS7_CodResp, A33TTBUS7_Pos});
                     pr_default.close(15);
                     if ( (pr_default.getStatus(15) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TTBUS007"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate067( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel067( ) ;
                           if ( AnyError == 0 )
                           {
                              if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                              {
                                 if ( AnyError == 0 )
                                 {
                                    context.nUserReturn = 1 ;
                                 }
                              }
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                        AnyError = 1 ;
                     }
                  }
               }
            }
            EndLevel067( ) ;
         }
         CloseExtendedTableCursors067( ) ;
      }

      protected void DeferredUpdate067( )
      {
      }

      protected void delete( )
      {
         BeforeValidate067( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency067( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls067( ) ;
            AfterConfirm067( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete067( ) ;
               if ( AnyError == 0 )
               {
                  ScanStart068( ) ;
                  while ( RcdFound8 != 0 )
                  {
                     getByPrimaryKey068( ) ;
                     Delete068( ) ;
                     ScanNext068( ) ;
                  }
                  ScanEnd068( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000618 */
                     pr_default.execute(16, new Object[] {A33TTBUS7_Pos});
                     pr_default.close(16);
                     if ( AnyError == 0 )
                     {
                        /* Start of After( delete) rules */
                        /* End of After( delete) rules */
                        if ( AnyError == 0 )
                        {
                           if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                           {
                              if ( AnyError == 0 )
                              {
                                 context.nUserReturn = 1 ;
                              }
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                        AnyError = 1 ;
                     }
                  }
               }
            }
         }
         sMode7 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel067( ) ;
         Gx_mode = sMode7 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls067( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000619 */
            pr_default.execute(17, new Object[] {A33TTBUS7_Pos});
            A34TTBUS7_Des = T000619_A34TTBUS7_Des[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
            n34TTBUS7_Des = T000619_n34TTBUS7_Des[0] ;
            pr_default.close(17);
            /* Using cursor T000620 */
            pr_default.execute(18, new Object[] {A35TTBUS7_CodResp});
            A36TTBUS7_DesResp = T000620_A36TTBUS7_DesResp[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
            n36TTBUS7_DesResp = T000620_n36TTBUS7_DesResp[0] ;
            pr_default.close(18);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000621 */
            pr_default.execute(19, new Object[] {A33TTBUS7_Pos});
            if ( (pr_default.getStatus(19) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Maestro de Bienes de Uso Trazabilizados"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(19);
         }
      }

      protected void ProcessNestedLevel068( )
      {
         nGXsfl_60_idx = 0 ;
         while ( nGXsfl_60_idx < nRC_Gridttbus007_permisos )
         {
            ReadRow068( ) ;
            if ( ( nRcdExists_8 != 0 ) || ( nIsMod_8 != 0 ) )
            {
               standaloneNotModal068( ) ;
               GetKey068( ) ;
               if ( ( nRcdExists_8 == 0 ) && ( nRcdDeleted_8 == 0 ) )
               {
                  if ( RcdFound8 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Insert068( ) ;
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "");
                     AnyError = 1 ;
                     GX_FocusControl = edtTTBUS7_CodUsuario_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound8 != 0 )
                  {
                     if ( ( nRcdDeleted_8 != 0 ) && ( nRcdExists_8 != 0 ) )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        Delete068( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_8 != 0 ) && ( nRcdExists_8 != 0 ) )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           Update068( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_8 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "");
                        AnyError = 1 ;
                        GX_FocusControl = edtTTBUS7_CodUsuario_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtTTBUS7_CodUsuario_Internalname, StringUtil.RTrim( A39TTBUS7_CodUsuario)) ;
            ChangePostValue( edtTTBUS7_DesUsuario_Internalname, StringUtil.RTrim( A199TTBUS7_DesUsuario)) ;
            ChangePostValue( chkTTBUS7_RespAux_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A51TTBUS7_RespAux), 1, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z39TTBUS7_CodUsuario_"+sGXsfl_60_idx, StringUtil.RTrim( Z39TTBUS7_CodUsuario)) ;
            ChangePostValue( "ZT_"+"Z51TTBUS7_RespAux_"+sGXsfl_60_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z51TTBUS7_RespAux), 1, 0, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_8_"+sGXsfl_60_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_8), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_8_"+sGXsfl_60_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_8), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_8_"+sGXsfl_60_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_8), 4, 0, ",", ""))) ;
            if ( nIsMod_8 != 0 )
            {
               ChangePostValue( "TTBUS7_CODUSUARIO_"+sGXsfl_60_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTTBUS7_CodUsuario_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "TTBUS7_DESUSUARIO_"+sGXsfl_60_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTTBUS7_DesUsuario_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "TTBUS7_RESPAUX_"+sGXsfl_60_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkTTBUS7_RespAux.Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll068( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_8 = 0 ;
         nIsMod_8 = 0 ;
         nRcdDeleted_8 = 0 ;
      }

      protected void ProcessLevel067( )
      {
         /* Save parent mode. */
         sMode7 = Gx_mode ;
         ProcessNestedLevel068( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode7 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         /* ' Update level parameters */
      }

      protected void EndLevel067( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(13);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete067( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(12);
            pr_default.close(11);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(17);
            pr_default.close(18);
            pr_default.close(2);
            context.CommitDataStores("TTBUS007");
            if ( AnyError == 0 )
            {
               ConfirmValues060( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(12);
            pr_default.close(11);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(17);
            pr_default.close(18);
            pr_default.close(2);
            context.RollbackDataStores("TTBUS007");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart067( )
      {
         /* Using cursor T000622 */
         pr_default.execute(20);
         RcdFound7 = 0 ;
         if ( (pr_default.getStatus(20) != 101) )
         {
            RcdFound7 = 1 ;
            A33TTBUS7_Pos = T000622_A33TTBUS7_Pos[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext067( )
      {
         pr_default.readNext(20);
         RcdFound7 = 0 ;
         if ( (pr_default.getStatus(20) != 101) )
         {
            RcdFound7 = 1 ;
            A33TTBUS7_Pos = T000622_A33TTBUS7_Pos[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
         }
      }

      protected void ScanEnd067( )
      {
      }

      protected void AfterConfirm067( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert067( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate067( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete067( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete067( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate067( )
      {
         /* Before Validate Rules */
      }

      protected void ZM068( short GX_JID )
      {
         if ( ( GX_JID == 8 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z51TTBUS7_RespAux = T00063_A51TTBUS7_RespAux[0] ;
            }
            else
            {
               Z51TTBUS7_RespAux = A51TTBUS7_RespAux ;
            }
         }
         if ( GX_JID == -8 )
         {
            Z33TTBUS7_Pos = A33TTBUS7_Pos ;
            Z51TTBUS7_RespAux = A51TTBUS7_RespAux ;
            Z39TTBUS7_CodUsuario = A39TTBUS7_CodUsuario ;
            Z199TTBUS7_DesUsuario = A199TTBUS7_DesUsuario ;
         }
      }

      protected void standaloneNotModal068( )
      {
      }

      protected void standaloneModal068( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtTTBUS7_CodUsuario_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS7_CodUsuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS7_CodUsuario_Enabled), 5, 0)));
         }
         else
         {
            edtTTBUS7_CodUsuario_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS7_CodUsuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS7_CodUsuario_Enabled), 5, 0)));
         }
      }

      protected void Load068( )
      {
         /* Using cursor T000623 */
         pr_default.execute(21, new Object[] {A33TTBUS7_Pos, A39TTBUS7_CodUsuario});
         if ( (pr_default.getStatus(21) != 101) )
         {
            RcdFound8 = 1 ;
            A199TTBUS7_DesUsuario = T000623_A199TTBUS7_DesUsuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TTBUS7_DesUsuario", A199TTBUS7_DesUsuario);
            n199TTBUS7_DesUsuario = T000623_n199TTBUS7_DesUsuario[0] ;
            A51TTBUS7_RespAux = T000623_A51TTBUS7_RespAux[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51TTBUS7_RespAux", StringUtil.Str( (decimal)(A51TTBUS7_RespAux), 1, 0));
            ZM068( -8) ;
         }
         pr_default.close(21);
         OnLoadActions068( ) ;
      }

      protected void OnLoadActions068( )
      {
      }

      protected void CheckExtendedTable068( )
      {
         Gx_BScreen = 1 ;
         standaloneModal068( ) ;
         /* Using cursor T00064 */
         pr_default.execute(2, new Object[] {A39TTBUS7_CodUsuario});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No existe 'Usuario con acceso a posicion trazabilidad'.", "ForeignKeyNotFound", 1, "TTBUS7_CODUSUARIO");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS7_CodUsuario_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A199TTBUS7_DesUsuario = T00064_A199TTBUS7_DesUsuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TTBUS7_DesUsuario", A199TTBUS7_DesUsuario);
            n199TTBUS7_DesUsuario = T00064_n199TTBUS7_DesUsuario[0] ;
         }
         pr_default.close(2);
         if ( true /* After */ && ( StringUtil.StrCmp(StringUtil.Trim( A39TTBUS7_CodUsuario), "") == 0 ) && ( A51TTBUS7_RespAux == 1 ) )
         {
            GX_msglist.addItem("Debe ingresar un usuario.", 1, "");
            AnyError = 1 ;
         }
      }

      protected void CloseExtendedTableCursors068( )
      {
         pr_default.close(2);
      }

      protected void enableDisable068( )
      {
      }

      protected void gxLoad_9( String A39TTBUS7_CodUsuario )
      {
         /* Using cursor T000624 */
         pr_default.execute(22, new Object[] {A39TTBUS7_CodUsuario});
         if ( (pr_default.getStatus(22) == 101) )
         {
            GX_msglist.addItem("No existe 'Usuario con acceso a posicion trazabilidad'.", "ForeignKeyNotFound", 1, "TTBUS7_CODUSUARIO");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS7_CodUsuario_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A199TTBUS7_DesUsuario = T000624_A199TTBUS7_DesUsuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TTBUS7_DesUsuario", A199TTBUS7_DesUsuario);
            n199TTBUS7_DesUsuario = T000624_n199TTBUS7_DesUsuario[0] ;
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A199TTBUS7_DesUsuario))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(22) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(22);
      }

      protected void GetKey068( )
      {
         /* Using cursor T000625 */
         pr_default.execute(23, new Object[] {A33TTBUS7_Pos, A39TTBUS7_CodUsuario});
         if ( (pr_default.getStatus(23) != 101) )
         {
            RcdFound8 = 1 ;
         }
         else
         {
            RcdFound8 = 0 ;
         }
         pr_default.close(23);
      }

      protected void getByPrimaryKey068( )
      {
         /* Using cursor T00063 */
         pr_default.execute(1, new Object[] {A33TTBUS7_Pos, A39TTBUS7_CodUsuario});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM068( 8) ;
            RcdFound8 = 1 ;
            InitializeNonKey068( ) ;
            A51TTBUS7_RespAux = T00063_A51TTBUS7_RespAux[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51TTBUS7_RespAux", StringUtil.Str( (decimal)(A51TTBUS7_RespAux), 1, 0));
            A39TTBUS7_CodUsuario = T00063_A39TTBUS7_CodUsuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39TTBUS7_CodUsuario", A39TTBUS7_CodUsuario);
            Z33TTBUS7_Pos = A33TTBUS7_Pos ;
            Z39TTBUS7_CodUsuario = A39TTBUS7_CodUsuario ;
            sMode8 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            Load068( ) ;
            Gx_mode = sMode8 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound8 = 0 ;
            InitializeNonKey068( ) ;
            sMode8 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal068( ) ;
            Gx_mode = sMode8 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency068( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00062 */
            pr_default.execute(0, new Object[] {A33TTBUS7_Pos, A39TTBUS7_CodUsuario});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TTBUS007Permisos"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z51TTBUS7_RespAux != T00062_A51TTBUS7_RespAux[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"TTBUS007Permisos"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert068( )
      {
         BeforeValidate068( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable068( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM068( 0) ;
            CheckOptimisticConcurrency068( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm068( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert068( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000626 */
                     pr_default.execute(24, new Object[] {A33TTBUS7_Pos, A51TTBUS7_RespAux, A39TTBUS7_CodUsuario});
                     pr_default.close(24);
                     if ( (pr_default.getStatus(24) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1 ;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                     AnyError = 1 ;
                  }
               }
            }
            else
            {
               Load068( ) ;
            }
            EndLevel068( ) ;
         }
         CloseExtendedTableCursors068( ) ;
      }

      protected void Update068( )
      {
         BeforeValidate068( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable068( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency068( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm068( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate068( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000627 */
                     pr_default.execute(25, new Object[] {A51TTBUS7_RespAux, A33TTBUS7_Pos, A39TTBUS7_CodUsuario});
                     pr_default.close(25);
                     if ( (pr_default.getStatus(25) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TTBUS007Permisos"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate068( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey068( ) ;
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                        AnyError = 1 ;
                     }
                  }
               }
            }
            EndLevel068( ) ;
         }
         CloseExtendedTableCursors068( ) ;
      }

      protected void DeferredUpdate068( )
      {
      }

      protected void Delete068( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate068( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency068( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls068( ) ;
            AfterConfirm068( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete068( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000628 */
                  pr_default.execute(26, new Object[] {A33TTBUS7_Pos, A39TTBUS7_CodUsuario});
                  pr_default.close(26);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                     AnyError = 1 ;
                  }
               }
            }
         }
         sMode8 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel068( ) ;
         Gx_mode = sMode8 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls068( )
      {
         standaloneModal068( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000629 */
            pr_default.execute(27, new Object[] {A39TTBUS7_CodUsuario});
            A199TTBUS7_DesUsuario = T000629_A199TTBUS7_DesUsuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TTBUS7_DesUsuario", A199TTBUS7_DesUsuario);
            n199TTBUS7_DesUsuario = T000629_n199TTBUS7_DesUsuario[0] ;
            pr_default.close(27);
         }
      }

      protected void EndLevel068( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart068( )
      {
         /* Using cursor T000630 */
         pr_default.execute(28, new Object[] {A33TTBUS7_Pos});
         RcdFound8 = 0 ;
         if ( (pr_default.getStatus(28) != 101) )
         {
            RcdFound8 = 1 ;
            A39TTBUS7_CodUsuario = T000630_A39TTBUS7_CodUsuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39TTBUS7_CodUsuario", A39TTBUS7_CodUsuario);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext068( )
      {
         pr_default.readNext(28);
         RcdFound8 = 0 ;
         if ( (pr_default.getStatus(28) != 101) )
         {
            RcdFound8 = 1 ;
            A39TTBUS7_CodUsuario = T000630_A39TTBUS7_CodUsuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39TTBUS7_CodUsuario", A39TTBUS7_CodUsuario);
         }
      }

      protected void ScanEnd068( )
      {
         pr_default.close(1);
      }

      protected void AfterConfirm068( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert068( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate068( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete068( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete068( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate068( )
      {
         /* Before Validate Rules */
      }

      protected void AddRow068( )
      {
         nGXsfl_60_idx = (short)(nGXsfl_60_idx+1) ;
         sGXsfl_60_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_60_idx), 4, 0)), 4, "0") ;
         edtTTBUS7_CodUsuario_Internalname = "TTBUS7_CODUSUARIO_"+sGXsfl_60_idx ;
         imgprompt_39_Internalname = "PROMPT_39_"+sGXsfl_60_idx ;
         edtTTBUS7_DesUsuario_Internalname = "TTBUS7_DESUSUARIO_"+sGXsfl_60_idx ;
         chkTTBUS7_RespAux_Internalname = "TTBUS7_RESPAUX_"+sGXsfl_60_idx ;
         SendRow068( ) ;
      }

      protected void SendRow068( )
      {
         Gridttbus007_permisosRow = GXWebRow.GetNew(context) ;
         if ( subGridttbus007_permisos_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridttbus007_permisos_Backstyle = 0 ;
            if ( StringUtil.StrCmp(subGridttbus007_permisos_Class, "") != 0 )
            {
               subGridttbus007_permisos_Linesclass = subGridttbus007_permisos_Class+"Odd" ;
            }
         }
         else if ( subGridttbus007_permisos_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridttbus007_permisos_Backstyle = 0 ;
            subGridttbus007_permisos_Backcolor = subGridttbus007_permisos_Allbackcolor ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridttbus007_permisosContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridttbus007_permisos_Backcolor), 9, 0)));
            if ( StringUtil.StrCmp(subGridttbus007_permisos_Class, "") != 0 )
            {
               subGridttbus007_permisos_Linesclass = subGridttbus007_permisos_Class+"Uniform" ;
            }
         }
         else if ( subGridttbus007_permisos_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridttbus007_permisos_Backstyle = 1 ;
            if ( StringUtil.StrCmp(subGridttbus007_permisos_Class, "") != 0 )
            {
               subGridttbus007_permisos_Linesclass = subGridttbus007_permisos_Class+"Odd" ;
            }
            subGridttbus007_permisos_Backcolor = (int)(0xF0F0F0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridttbus007_permisosContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridttbus007_permisos_Backcolor), 9, 0)));
         }
         else if ( subGridttbus007_permisos_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridttbus007_permisos_Backstyle = 1 ;
            if ( ((int)(nGXsfl_60_idx) % (2)) == 0 )
            {
               subGridttbus007_permisos_Backcolor = (int)(0x0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridttbus007_permisosContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridttbus007_permisos_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridttbus007_permisos_Class, "") != 0 )
               {
                  subGridttbus007_permisos_Linesclass = subGridttbus007_permisos_Class+"Even" ;
               }
            }
            else
            {
               subGridttbus007_permisos_Backcolor = (int)(0xF0F0F0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridttbus007_permisosContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridttbus007_permisos_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridttbus007_permisos_Class, "") != 0 )
               {
                  subGridttbus007_permisos_Linesclass = subGridttbus007_permisos_Class+"Odd" ;
               }
            }
         }
         imgprompt_39_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0)||(StringUtil.StrCmp(Gx_mode, "UPD")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00f0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"TTBUS7_CODUSUARIO_"+sGXsfl_60_idx+"'), id:'"+"TTBUS7_CODUSUARIO_"+sGXsfl_60_idx+"'"+",isOut:true,isKey:false,isLastKey:false}"+"],"+"gx.dom.form()."+"nIsMod_8_"+sGXsfl_60_idx+","+"'', false"+","+"false"+","+"false"+");") ;
         imgprompt_33_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0)||(StringUtil.StrCmp(Gx_mode, "UPD")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0081.aspx"+"',["+"{Ctrl:gx.dom.el('"+"TTBUS7_POS"+"'), id:'"+"TTBUS7_POS"+"'"+",isOut:false,isKey:true,isLastKey:true}"+","+"{Ctrl:gx.dom.el('"+"TTBUS7_CODUSUARIO_"+sGXsfl_60_idx+"'), id:'"+"TTBUS7_CODUSUARIO_"+sGXsfl_60_idx+"'"+",isOut:true,isKey:false,isLastKey:false}"+"],"+"gx.dom.form()."+"nIsMod_8_"+sGXsfl_60_idx+","+"'', false"+","+"false"+","+"false"+");") ;
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_8_" + sGXsfl_60_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 61,'',false,'" + sGXsfl_60_idx + "',60)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridttbus007_permisosRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS7_CodUsuario_Internalname,StringUtil.RTrim( A39TTBUS7_CodUsuario),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)16,(short)-1,(int)edtTTBUS7_CodUsuario_Enabled,(short)1,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A39TTBUS7_CodUsuario, "@!")),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(61);\"",(short)0,(String)edtTTBUS7_CodUsuario_Jsonclick,(String)"",(short)60,(short)1,(short)-1,(bool)true,(String)"left"});
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "Image" ;
         StyleString = "" ;
         Gridttbus007_permisosRow.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)imgprompt_39_Internalname,(String)"","prompt.gif",(String)"Modern",(int)imgprompt_39_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(String)imgprompt_39_Link,(String)"",(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
         /* Subfile cell */
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridttbus007_permisosRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS7_DesUsuario_Internalname,StringUtil.RTrim( A199TTBUS7_DesUsuario),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(int)edtTTBUS7_DesUsuario_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A199TTBUS7_DesUsuario, "@!")),(String)"",(short)0,(String)edtTTBUS7_DesUsuario_Jsonclick,(String)"",(short)60,(short)1,(short)-1,(bool)true,(String)"left"});
         /* Subfile cell */
         /* Check box */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_8_" + sGXsfl_60_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 63,'',false,'" + sGXsfl_60_idx + "',60)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         Gridttbus007_permisosRow.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkTTBUS7_RespAux_Internalname,StringUtil.Str( (decimal)(A51TTBUS7_RespAux), 1, 0),(String)"",(short)-1,chkTTBUS7_RespAux.Enabled,(String)"1",(String)"",(String)StyleString,(String)ClassString,TempTags+" onclick=\"gx.fn.checkboxClick(63, this, 1, 0);gx.evt.onchange(this);\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(63);\""});
         context.httpAjaxContext.ajax_sending_grid_row(Gridttbus007_permisosRow);
         GXCCtl = "Z39TTBUS7_CodUsuario_" + sGXsfl_60_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z39TTBUS7_CodUsuario));
         GXCCtl = "Z51TTBUS7_RespAux_" + sGXsfl_60_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z51TTBUS7_RespAux), 1, 0, ",", "")));
         GXCCtl = "nRcdDeleted_8_" + sGXsfl_60_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_8), 4, 0, ",", "")));
         GXCCtl = "nRcdExists_8_" + sGXsfl_60_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_8), 4, 0, ",", "")));
         GXCCtl = "nIsMod_8_" + sGXsfl_60_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_8), 4, 0, ",", "")));
         GXCCtl = "vTTBUS3_POS_" + sGXsfl_60_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9TTBUS3_Pos), 3, 0, ",", "")));
         GXCCtl = "vMODE_" + sGXsfl_60_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GXCCtl = "vSISTEMA_" + sGXsfl_60_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( AV7SISTEMA));
         GXCCtl = "vUSUARIO_" + sGXsfl_60_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( AV8USUARIO));
         GxWebStd.gx_hidden_field( context, "TTBUS7_CODUSUARIO_"+sGXsfl_60_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTTBUS7_CodUsuario_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TTBUS7_DESUSUARIO_"+sGXsfl_60_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTTBUS7_DesUsuario_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TTBUS7_RESPAUX_"+sGXsfl_60_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkTTBUS7_RespAux.Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PROMPT_39_"+sGXsfl_60_idx+"Link", StringUtil.RTrim( imgprompt_39_Link));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridttbus007_permisosContainer.AddRow(Gridttbus007_permisosRow);
      }

      protected void ReadRow068( )
      {
         nGXsfl_60_idx = (short)(nGXsfl_60_idx+1) ;
         sGXsfl_60_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_60_idx), 4, 0)), 4, "0") ;
         edtTTBUS7_CodUsuario_Internalname = "TTBUS7_CODUSUARIO_"+sGXsfl_60_idx ;
         imgprompt_39_Internalname = "PROMPT_39_"+sGXsfl_60_idx ;
         edtTTBUS7_DesUsuario_Internalname = "TTBUS7_DESUSUARIO_"+sGXsfl_60_idx ;
         chkTTBUS7_RespAux_Internalname = "TTBUS7_RESPAUX_"+sGXsfl_60_idx ;
         edtTTBUS7_CodUsuario_Enabled = (int)(context.localUtil.CToN( cgiGet( "TTBUS7_CODUSUARIO_"+sGXsfl_60_idx+"Enabled"), ",", ".")) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS7_CodUsuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS7_CodUsuario_Enabled), 5, 0)));
         edtTTBUS7_DesUsuario_Enabled = (int)(context.localUtil.CToN( cgiGet( "TTBUS7_DESUSUARIO_"+sGXsfl_60_idx+"Enabled"), ",", ".")) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS7_DesUsuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS7_DesUsuario_Enabled), 5, 0)));
         chkTTBUS7_RespAux.Enabled = (int)(context.localUtil.CToN( cgiGet( "TTBUS7_RESPAUX_"+sGXsfl_60_idx+"Enabled"), ",", ".")) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkTTBUS7_RespAux_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkTTBUS7_RespAux.Enabled), 5, 0)));
         imgprompt_33_Link = cgiGet( "PROMPT_39_"+sGXsfl_60_idx+"Link") ;
         A39TTBUS7_CodUsuario = StringUtil.Upper( cgiGet( edtTTBUS7_CodUsuario_Internalname)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39TTBUS7_CodUsuario", A39TTBUS7_CodUsuario);
         A199TTBUS7_DesUsuario = StringUtil.Upper( cgiGet( edtTTBUS7_DesUsuario_Internalname)) ;
         n199TTBUS7_DesUsuario = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TTBUS7_DesUsuario", A199TTBUS7_DesUsuario);
         if ( ! context.localUtil.VCNumber( cgiGet( chkTTBUS7_RespAux_Internalname), "9") || ( ((StringUtil.StrCmp(cgiGet( chkTTBUS7_RespAux_Internalname), "1")==0) ? 1 : 0) < 0 ) || ( ( ((StringUtil.StrCmp(cgiGet( chkTTBUS7_RespAux_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "TTBUS7_RESPAUX");
            AnyError = 1 ;
            GX_FocusControl = chkTTBUS7_RespAux_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A51TTBUS7_RespAux = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51TTBUS7_RespAux", StringUtil.Str( (decimal)(A51TTBUS7_RespAux), 1, 0));
         }
         else
         {
            A51TTBUS7_RespAux = (short)(((StringUtil.StrCmp(cgiGet( chkTTBUS7_RespAux_Internalname), "1")==0) ? 1 : 0)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51TTBUS7_RespAux", StringUtil.Str( (decimal)(A51TTBUS7_RespAux), 1, 0));
         }
         GXCCtl = "Z39TTBUS7_CodUsuario_" + sGXsfl_60_idx ;
         Z39TTBUS7_CodUsuario = cgiGet( GXCCtl) ;
         GXCCtl = "Z51TTBUS7_RespAux_" + sGXsfl_60_idx ;
         Z51TTBUS7_RespAux = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", ".")) ;
         GXCCtl = "nRcdDeleted_8_" + sGXsfl_60_idx ;
         nRcdDeleted_8 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", ".")) ;
         GXCCtl = "nRcdExists_8_" + sGXsfl_60_idx ;
         nRcdExists_8 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", ".")) ;
         GXCCtl = "nIsMod_8_" + sGXsfl_60_idx ;
         nIsMod_8 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", ".")) ;
         GXCCtl = "vTTBUS3_POS_" + sGXsfl_60_idx ;
         AV9TTBUS3_Pos = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", ".")) ;
         GXCCtl = "vSISTEMA_" + sGXsfl_60_idx ;
         AV7SISTEMA = cgiGet( GXCCtl) ;
         GXCCtl = "vUSUARIO_" + sGXsfl_60_idx ;
         AV8USUARIO = cgiGet( GXCCtl) ;
      }

      protected void assign_properties_default( )
      {
         defedtTTBUS7_CodUsuario_Enabled = edtTTBUS7_CodUsuario_Enabled ;
      }

      protected void ConfirmValues060( )
      {
         nGXsfl_60_idx = 0 ;
         sGXsfl_60_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_60_idx), 4, 0)), 4, "0") ;
         edtTTBUS7_CodUsuario_Internalname = "TTBUS7_CODUSUARIO_"+sGXsfl_60_idx ;
         imgprompt_39_Internalname = "PROMPT_39_"+sGXsfl_60_idx ;
         edtTTBUS7_DesUsuario_Internalname = "TTBUS7_DESUSUARIO_"+sGXsfl_60_idx ;
         chkTTBUS7_RespAux_Internalname = "TTBUS7_RESPAUX_"+sGXsfl_60_idx ;
         while ( nGXsfl_60_idx < nRC_Gridttbus007_permisos )
         {
            nGXsfl_60_idx = (short)(nGXsfl_60_idx+1) ;
            sGXsfl_60_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_60_idx), 4, 0)), 4, "0") ;
            edtTTBUS7_CodUsuario_Internalname = "TTBUS7_CODUSUARIO_"+sGXsfl_60_idx ;
            imgprompt_39_Internalname = "PROMPT_39_"+sGXsfl_60_idx ;
            edtTTBUS7_DesUsuario_Internalname = "TTBUS7_DESUSUARIO_"+sGXsfl_60_idx ;
            chkTTBUS7_RespAux_Internalname = "TTBUS7_RESPAUX_"+sGXsfl_60_idx ;
            ChangePostValue( "Z39TTBUS7_CodUsuario_"+sGXsfl_60_idx, cgiGet( "ZT_"+"Z39TTBUS7_CodUsuario_"+sGXsfl_60_idx)) ;
            DeletePostValue( "ZT_"+"Z39TTBUS7_CodUsuario_"+sGXsfl_60_idx) ;
            ChangePostValue( "Z51TTBUS7_RespAux_"+sGXsfl_60_idx, cgiGet( "ZT_"+"Z51TTBUS7_RespAux_"+sGXsfl_60_idx)) ;
            DeletePostValue( "ZT_"+"Z51TTBUS7_RespAux_"+sGXsfl_60_idx) ;
         }
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, "IE=EmulateIE7");
      }

      public override void RenderHtmlOpenForm( )
      {
         context.WriteHtmlText( "<title>") ;
         context.WriteHtmlText( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         MasterPageObj.master_styles();
         if ( ! context.isSmartDevice( ) )
         {
            context.AddJavascriptSource("gxgral.js", "?42940");
            context.AddJavascriptSource("gxcfg.js", "?42940");
         }
         else
         {
            context.AddJavascriptSource("gxapiSD.js", "?42940");
            context.AddJavascriptSource("gxfxSD.js", "?42940");
            context.AddJavascriptSource("gxtypesSD.js", "?42940");
            context.AddJavascriptSource("gxpopupSD.js", "?42940");
            context.AddJavascriptSource("gxfrmutlSD.js", "?42940");
            context.AddJavascriptSource("gxgridSD.js", "?42940");
            context.AddJavascriptSource("JavaScripTableSD.js", "?42940");
            context.AddJavascriptSource("rijndaelSD.js", "?42940");
            context.AddJavascriptSource("gxgralSD.js", "?42940");
            context.AddJavascriptSource("gxcfg.js", "?42940");
         }
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,true,false)\" onkeydown=\"gx.evt.onkeypress(null,true,false)\"" ;
         context.WriteHtmlText( "<body") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background=\""+context.convertURL( Form.Background)+"\"") ;
         }
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+"\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("ttbus007.aspx") + "?" + UrlEncode("" +AV9TTBUS3_Pos) + "," + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV7SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV8USUARIO))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z33TTBUS7_Pos", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z33TTBUS7_Pos), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z35TTBUS7_CodResp", StringUtil.RTrim( Z35TTBUS7_CodResp));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "nRC_Gridttbus007_permisos", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_60_idx), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vSISTEMA", StringUtil.RTrim( AV7SISTEMA));
         GxWebStd.gx_hidden_field( context, "vUSUARIO", StringUtil.RTrim( AV8USUARIO));
         GxWebStd.gx_hidden_field( context, "vTTBUS3_POS", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9TTBUS3_Pos), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendComponentObjects();
         SendServerCommands();
         SendState();
         context.WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
      }

      public override short ExecuteStartEvent( )
      {
         standaloneStartup( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         return gxajaxcallmode ;
      }

      public override void RenderHtmlContent( )
      {
         Draw( ) ;
      }

      public override void DispatchEvents( )
      {
         Process( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "TTBUS007" ;
      }

      public override String GetPgmdesc( )
      {
         return "Administración de Responsables Trazabilidad" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("ttbus007.aspx") + "?" + UrlEncode("" +AV9TTBUS3_Pos) + "," + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV7SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV8USUARIO)) ;
      }

      protected void InitializeNonKey067( )
      {
         A34TTBUS7_Des = "" ;
         n34TTBUS7_Des = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
         A35TTBUS7_CodResp = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
         A36TTBUS7_DesResp = "" ;
         n36TTBUS7_DesResp = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
      }

      protected void InitAll067( )
      {
         A33TTBUS7_Pos = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
         InitializeNonKey067( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey068( )
      {
         A199TTBUS7_DesUsuario = "" ;
         n199TTBUS7_DesUsuario = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TTBUS7_DesUsuario", A199TTBUS7_DesUsuario);
         A51TTBUS7_RespAux = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51TTBUS7_RespAux", StringUtil.Str( (decimal)(A51TTBUS7_RespAux), 1, 0));
      }

      protected void InitAll068( )
      {
         A39TTBUS7_CodUsuario = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39TTBUS7_CodUsuario", A39TTBUS7_CodUsuario);
         InitializeNonKey068( ) ;
      }

      protected void StandaloneModalInsert068( )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Modern.css", "?2051812");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1930836");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("ttbus007.js", "?1930836");
         /* End function include_jscripts */
      }

      protected void init_level_properties8( )
      {
         edtTTBUS7_CodUsuario_Enabled = defedtTTBUS7_CodUsuario_Enabled ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS7_CodUsuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS7_CodUsuario_Enabled), 5, 0)));
      }

      protected void init_default_properties( )
      {
         imgBtn_first_Internalname = "BTN_FIRST" ;
         imgBtn_first_separator_Internalname = "BTN_FIRST_SEPARATOR" ;
         imgBtn_previous_Internalname = "BTN_PREVIOUS" ;
         imgBtn_previous_separator_Internalname = "BTN_PREVIOUS_SEPARATOR" ;
         imgBtn_next_Internalname = "BTN_NEXT" ;
         imgBtn_next_separator_Internalname = "BTN_NEXT_SEPARATOR" ;
         imgBtn_last_Internalname = "BTN_LAST" ;
         imgBtn_last_separator_Internalname = "BTN_LAST_SEPARATOR" ;
         imgBtn_select_Internalname = "BTN_SELECT" ;
         imgBtn_select_separator_Internalname = "BTN_SELECT_SEPARATOR" ;
         imgBtn_enter2_Internalname = "BTN_ENTER2" ;
         imgBtn_enter2_separator_Internalname = "BTN_ENTER2_SEPARATOR" ;
         imgBtn_cancel2_Internalname = "BTN_CANCEL2" ;
         imgBtn_cancel2_separator_Internalname = "BTN_CANCEL2_SEPARATOR" ;
         imgBtn_delete2_Internalname = "BTN_DELETE2" ;
         imgBtn_delete2_separator_Internalname = "BTN_DELETE2_SEPARATOR" ;
         tblTabletoolbar_Internalname = "TABLETOOLBAR" ;
         lblTextblockttbus7_pos_Internalname = "TEXTBLOCKTTBUS7_POS" ;
         edtTTBUS7_Pos_Internalname = "TTBUS7_POS" ;
         lblTextblockttbus7_des_Internalname = "TEXTBLOCKTTBUS7_DES" ;
         edtTTBUS7_Des_Internalname = "TTBUS7_DES" ;
         lblTextblockttbus7_codresp_Internalname = "TEXTBLOCKTTBUS7_CODRESP" ;
         edtTTBUS7_CodResp_Internalname = "TTBUS7_CODRESP" ;
         lblTextblockttbus7_desresp_Internalname = "TEXTBLOCKTTBUS7_DESRESP" ;
         edtTTBUS7_DesResp_Internalname = "TTBUS7_DESRESP" ;
         lblTitlepermisos_Internalname = "TITLEPERMISOS" ;
         tblTable3_Internalname = "TABLE3" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_33_Internalname = "PROMPT_33" ;
         imgprompt_35_Internalname = "PROMPT_35" ;
         subGridttbus007_permisos_Internalname = "GRIDTTBUS007_PERMISOS" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Administración de Responsables Trazabilidad" ;
         edtTTBUS7_DesUsuario_Jsonclick = "" ;
         imgprompt_39_Visible = 1 ;
         imgprompt_39_Link = "" ;
         imgprompt_33_Visible = 1 ;
         edtTTBUS7_CodUsuario_Jsonclick = "" ;
         subGridttbus007_permisos_Class = "Grid" ;
         imgBtn_delete2_separator_Visible = 1 ;
         imgBtn_delete2_Enabled = 1 ;
         imgBtn_delete2_Visible = 1 ;
         imgBtn_cancel2_separator_Visible = 1 ;
         imgBtn_cancel2_Visible = 1 ;
         imgBtn_enter2_separator_Visible = 1 ;
         imgBtn_enter2_Enabled = 1 ;
         imgBtn_enter2_Visible = 1 ;
         imgBtn_select_separator_Visible = 1 ;
         imgBtn_select_Visible = 1 ;
         imgBtn_last_separator_Visible = 1 ;
         imgBtn_last_Visible = 1 ;
         imgBtn_next_separator_Visible = 1 ;
         imgBtn_next_Visible = 1 ;
         imgBtn_previous_separator_Visible = 1 ;
         imgBtn_previous_Visible = 1 ;
         imgBtn_first_separator_Visible = 1 ;
         imgBtn_first_Visible = 1 ;
         chkTTBUS7_RespAux.Enabled = 1 ;
         edtTTBUS7_DesUsuario_Enabled = 0 ;
         edtTTBUS7_CodUsuario_Enabled = 1 ;
         subGridttbus007_permisos_Backcolorstyle = 2 ;
         edtTTBUS7_DesResp_Jsonclick = "" ;
         edtTTBUS7_DesResp_Enabled = 0 ;
         imgprompt_35_Visible = 1 ;
         imgprompt_35_Link = "" ;
         edtTTBUS7_CodResp_Jsonclick = "" ;
         edtTTBUS7_CodResp_Enabled = 1 ;
         edtTTBUS7_Des_Jsonclick = "" ;
         edtTTBUS7_Des_Enabled = 0 ;
         imgprompt_33_Visible = 1 ;
         imgprompt_33_Link = "" ;
         edtTTBUS7_Pos_Jsonclick = "" ;
         edtTTBUS7_Pos_Enabled = 1 ;
         bttBtn_delete_Visible = 1 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_enter_Visible = 1 ;
         chkTTBUS7_RespAux.Caption = "" ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGridttbus007_permisos_newrow( short nRC_Gridttbus007_permisos ,
                                                       short nGXsfl_60_idx ,
                                                       String sGXsfl_60_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         edtTTBUS7_CodUsuario_Internalname = "TTBUS7_CODUSUARIO_"+sGXsfl_60_idx ;
         imgprompt_39_Internalname = "PROMPT_39_"+sGXsfl_60_idx ;
         edtTTBUS7_DesUsuario_Internalname = "TTBUS7_DESUSUARIO_"+sGXsfl_60_idx ;
         chkTTBUS7_RespAux_Internalname = "TTBUS7_RESPAUX_"+sGXsfl_60_idx ;
         while ( nGXsfl_60_idx <= nRC_Gridttbus007_permisos )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal068( ) ;
            standaloneModal068( ) ;
            GXCCtl = "TTBUS7_RESPAUX_" + sGXsfl_60_idx ;
            chkTTBUS7_RespAux.Name = GXCCtl ;
            chkTTBUS7_RespAux.WebTags = "" ;
            chkTTBUS7_RespAux.Caption = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkTTBUS7_RespAux_Internalname, "Caption", chkTTBUS7_RespAux.Caption);
            chkTTBUS7_RespAux.CheckedValue = "0" ;
            dynload_actions( ) ;
            SendRow068( ) ;
            nGXsfl_60_idx = (short)(nGXsfl_60_idx+1) ;
            sGXsfl_60_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_60_idx), 4, 0)), 4, "0") ;
            edtTTBUS7_CodUsuario_Internalname = "TTBUS7_CODUSUARIO_"+sGXsfl_60_idx ;
            imgprompt_39_Internalname = "PROMPT_39_"+sGXsfl_60_idx ;
            edtTTBUS7_DesUsuario_Internalname = "TTBUS7_DESUSUARIO_"+sGXsfl_60_idx ;
            chkTTBUS7_RespAux_Internalname = "TTBUS7_RESPAUX_"+sGXsfl_60_idx ;
         }
         context.GX_webresponse.AddString(Gridttbus007_permisosContainer.ToJavascriptSource());
         /* End function gxnrGridttbus007_permisos_newrow */
      }

      public void Valid_Ttbus7_pos( short GX_Parm1 ,
                                    String GX_Parm2 )
      {
         A33TTBUS7_Pos = GX_Parm1 ;
         A34TTBUS7_Des = GX_Parm2 ;
         n34TTBUS7_Des = false ;
         /* Using cursor T000619 */
         pr_default.execute(17, new Object[] {A33TTBUS7_Pos});
         if ( (pr_default.getStatus(17) == 101) )
         {
            GX_msglist.addItem("No existe 'Posición Trazabilidad'.", "ForeignKeyNotFound", 1, "TTBUS7_POS");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS7_Pos_Internalname ;
         }
         if ( AnyError == 0 )
         {
            A34TTBUS7_Des = T000619_A34TTBUS7_Des[0] ;
            n34TTBUS7_Des = T000619_n34TTBUS7_Des[0] ;
         }
         pr_default.close(17);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A34TTBUS7_Des = "" ;
            n34TTBUS7_Des = false ;
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A34TTBUS7_Des)));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
      }

      public void Valid_Ttbus7_codresp( String GX_Parm1 ,
                                        String GX_Parm2 )
      {
         A35TTBUS7_CodResp = GX_Parm1 ;
         A36TTBUS7_DesResp = GX_Parm2 ;
         n36TTBUS7_DesResp = false ;
         /* Using cursor T000620 */
         pr_default.execute(18, new Object[] {A35TTBUS7_CodResp});
         if ( (pr_default.getStatus(18) == 101) )
         {
            GX_msglist.addItem("No existe 'Responsable de Posición'.", "ForeignKeyNotFound", 1, "TTBUS7_CODRESP");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS7_CodResp_Internalname ;
         }
         if ( AnyError == 0 )
         {
            A36TTBUS7_DesResp = T000620_A36TTBUS7_DesResp[0] ;
            n36TTBUS7_DesResp = T000620_n36TTBUS7_DesResp[0] ;
         }
         pr_default.close(18);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A36TTBUS7_DesResp = "" ;
            n36TTBUS7_DesResp = false ;
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A36TTBUS7_DesResp)));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
      }

      public void Valid_Ttbus7_codusuario( String GX_Parm1 ,
                                           String GX_Parm2 )
      {
         A39TTBUS7_CodUsuario = GX_Parm1 ;
         A199TTBUS7_DesUsuario = GX_Parm2 ;
         n199TTBUS7_DesUsuario = false ;
         /* Using cursor T000629 */
         pr_default.execute(27, new Object[] {A39TTBUS7_CodUsuario});
         if ( (pr_default.getStatus(27) == 101) )
         {
            GX_msglist.addItem("No existe 'Usuario con acceso a posicion trazabilidad'.", "ForeignKeyNotFound", 1, "TTBUS7_CODUSUARIO");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS7_CodUsuario_Internalname ;
         }
         if ( AnyError == 0 )
         {
            A199TTBUS7_DesUsuario = T000629_A199TTBUS7_DesUsuario[0] ;
            n199TTBUS7_DesUsuario = T000629_n199TTBUS7_DesUsuario[0] ;
         }
         pr_default.close(27);
         if ( true /* After */ && ( StringUtil.StrCmp(StringUtil.Trim( A39TTBUS7_CodUsuario), "") == 0 ) && ( A51TTBUS7_RespAux == 1 ) )
         {
            GX_msglist.addItem("Debe ingresar un usuario.", 1, "TTBUS7_CODUSUARIO");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS7_CodUsuario_Internalname ;
         }
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A199TTBUS7_DesUsuario = "" ;
            n199TTBUS7_DesUsuario = false ;
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A199TTBUS7_DesUsuario)));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
      }

      protected void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
         pr_default.close(28);
         pr_default.close(27);
         pr_default.close(20);
         pr_default.close(12);
         pr_default.close(11);
         pr_default.close(17);
         pr_default.close(18);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         wcpOGx_mode = "" ;
         wcpOAV7SISTEMA = "" ;
         wcpOAV8USUARIO = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A35TTBUS7_CodResp = "" ;
         A39TTBUS7_CodUsuario = "" ;
         GXCCtl = "" ;
         chkTTBUS7_RespAux_Internalname = "" ;
         PreviousTooltip = "" ;
         PreviousCaption = "" ;
         Form = new GXWebForm();
         GX_FocusControl = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         TempTags = "" ;
         bttBtn_enter_Jsonclick = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         bttBtn_delete_Jsonclick = "" ;
         lblTextblockttbus7_pos_Jsonclick = "" ;
         lblTextblockttbus7_des_Jsonclick = "" ;
         A34TTBUS7_Des = "" ;
         lblTextblockttbus7_codresp_Jsonclick = "" ;
         lblTextblockttbus7_desresp_Jsonclick = "" ;
         A36TTBUS7_DesResp = "" ;
         Gridttbus007_permisosContainer = new GXWebGrid( context);
         Gridttbus007_permisosColumn = new GXWebColumn();
         A199TTBUS7_DesUsuario = "" ;
         sMode8 = "" ;
         edtTTBUS7_CodUsuario_Internalname = "" ;
         edtTTBUS7_DesUsuario_Internalname = "" ;
         lblTitlepermisos_Jsonclick = "" ;
         imgBtn_first_Jsonclick = "" ;
         imgBtn_first_separator_Jsonclick = "" ;
         imgBtn_previous_Jsonclick = "" ;
         imgBtn_previous_separator_Jsonclick = "" ;
         imgBtn_next_Jsonclick = "" ;
         imgBtn_next_separator_Jsonclick = "" ;
         imgBtn_last_Jsonclick = "" ;
         imgBtn_last_separator_Jsonclick = "" ;
         imgBtn_select_Jsonclick = "" ;
         imgBtn_select_separator_Jsonclick = "" ;
         imgBtn_enter2_Jsonclick = "" ;
         imgBtn_enter2_separator_Jsonclick = "" ;
         imgBtn_cancel2_Jsonclick = "" ;
         imgBtn_cancel2_separator_Jsonclick = "" ;
         imgBtn_delete2_Jsonclick = "" ;
         imgBtn_delete2_separator_Jsonclick = "" ;
         Z35TTBUS7_CodResp = "" ;
         sMode7 = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         Z39TTBUS7_CodUsuario = "" ;
         Z34TTBUS7_Des = "" ;
         Z36TTBUS7_DesResp = "" ;
         T00067_A34TTBUS7_Des = new String[] {""} ;
         T00067_n34TTBUS7_Des = new bool[] {false} ;
         T00069_A34TTBUS7_Des = new String[] {""} ;
         T00069_n34TTBUS7_Des = new bool[] {false} ;
         T00069_A36TTBUS7_DesResp = new String[] {""} ;
         T00069_n36TTBUS7_DesResp = new bool[] {false} ;
         T00069_A33TTBUS7_Pos = new short[1] ;
         T00069_A35TTBUS7_CodResp = new String[] {""} ;
         T00068_A36TTBUS7_DesResp = new String[] {""} ;
         T00068_n36TTBUS7_DesResp = new bool[] {false} ;
         T000610_A34TTBUS7_Des = new String[] {""} ;
         T000610_n34TTBUS7_Des = new bool[] {false} ;
         T000611_A36TTBUS7_DesResp = new String[] {""} ;
         T000611_n36TTBUS7_DesResp = new bool[] {false} ;
         T000612_A33TTBUS7_Pos = new short[1] ;
         T00066_A33TTBUS7_Pos = new short[1] ;
         T00066_A35TTBUS7_CodResp = new String[] {""} ;
         T000613_A33TTBUS7_Pos = new short[1] ;
         T000614_A33TTBUS7_Pos = new short[1] ;
         T000615_A33TTBUS7_Pos = new short[1] ;
         T000615_A35TTBUS7_CodResp = new String[] {""} ;
         T000619_A34TTBUS7_Des = new String[] {""} ;
         T000619_n34TTBUS7_Des = new bool[] {false} ;
         T000620_A36TTBUS7_DesResp = new String[] {""} ;
         T000620_n36TTBUS7_DesResp = new bool[] {false} ;
         T000621_A11TTBUS_Id = new int[1] ;
         T000622_A33TTBUS7_Pos = new short[1] ;
         Z199TTBUS7_DesUsuario = "" ;
         T000623_A33TTBUS7_Pos = new short[1] ;
         T000623_A199TTBUS7_DesUsuario = new String[] {""} ;
         T000623_n199TTBUS7_DesUsuario = new bool[] {false} ;
         T000623_A51TTBUS7_RespAux = new short[1] ;
         T000623_A39TTBUS7_CodUsuario = new String[] {""} ;
         T00064_A199TTBUS7_DesUsuario = new String[] {""} ;
         T00064_n199TTBUS7_DesUsuario = new bool[] {false} ;
         T000624_A199TTBUS7_DesUsuario = new String[] {""} ;
         T000624_n199TTBUS7_DesUsuario = new bool[] {false} ;
         T000625_A33TTBUS7_Pos = new short[1] ;
         T000625_A39TTBUS7_CodUsuario = new String[] {""} ;
         T00063_A33TTBUS7_Pos = new short[1] ;
         T00063_A51TTBUS7_RespAux = new short[1] ;
         T00063_A39TTBUS7_CodUsuario = new String[] {""} ;
         T00062_A33TTBUS7_Pos = new short[1] ;
         T00062_A51TTBUS7_RespAux = new short[1] ;
         T00062_A39TTBUS7_CodUsuario = new String[] {""} ;
         T000629_A199TTBUS7_DesUsuario = new String[] {""} ;
         T000629_n199TTBUS7_DesUsuario = new bool[] {false} ;
         T000630_A33TTBUS7_Pos = new short[1] ;
         T000630_A39TTBUS7_CodUsuario = new String[] {""} ;
         imgprompt_39_Internalname = "" ;
         Gridttbus007_permisosRow = new GXWebRow();
         subGridttbus007_permisos_Linesclass = "" ;
         ROClassString = "" ;
         GXt_char4 = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char6 = "" ;
         GXt_char5 = "" ;
         GXt_char7 = "" ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ttbus007__default(),
            new Object[][] {
                new Object[] {
               T00062_A33TTBUS7_Pos, T00062_A51TTBUS7_RespAux, T00062_A39TTBUS7_CodUsuario
               }
               , new Object[] {
               T00063_A33TTBUS7_Pos, T00063_A51TTBUS7_RespAux, T00063_A39TTBUS7_CodUsuario
               }
               , new Object[] {
               T00064_A199TTBUS7_DesUsuario, T00064_n199TTBUS7_DesUsuario
               }
               , new Object[] {
               T00065_A33TTBUS7_Pos, T00065_A35TTBUS7_CodResp
               }
               , new Object[] {
               T00066_A33TTBUS7_Pos, T00066_A35TTBUS7_CodResp
               }
               , new Object[] {
               T00067_A34TTBUS7_Des, T00067_n34TTBUS7_Des
               }
               , new Object[] {
               T00068_A36TTBUS7_DesResp, T00068_n36TTBUS7_DesResp
               }
               , new Object[] {
               T00069_A34TTBUS7_Des, T00069_n34TTBUS7_Des, T00069_A36TTBUS7_DesResp, T00069_n36TTBUS7_DesResp, T00069_A33TTBUS7_Pos, T00069_A35TTBUS7_CodResp
               }
               , new Object[] {
               T000610_A34TTBUS7_Des, T000610_n34TTBUS7_Des
               }
               , new Object[] {
               T000611_A36TTBUS7_DesResp, T000611_n36TTBUS7_DesResp
               }
               , new Object[] {
               T000612_A33TTBUS7_Pos
               }
               , new Object[] {
               T000613_A33TTBUS7_Pos
               }
               , new Object[] {
               T000614_A33TTBUS7_Pos
               }
               , new Object[] {
               T000615_A33TTBUS7_Pos, T000615_A35TTBUS7_CodResp
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000619_A34TTBUS7_Des, T000619_n34TTBUS7_Des
               }
               , new Object[] {
               T000620_A36TTBUS7_DesResp, T000620_n36TTBUS7_DesResp
               }
               , new Object[] {
               T000621_A11TTBUS_Id
               }
               , new Object[] {
               T000622_A33TTBUS7_Pos
               }
               , new Object[] {
               T000623_A33TTBUS7_Pos, T000623_A199TTBUS7_DesUsuario, T000623_n199TTBUS7_DesUsuario, T000623_A51TTBUS7_RespAux, T000623_A39TTBUS7_CodUsuario
               }
               , new Object[] {
               T000624_A199TTBUS7_DesUsuario, T000624_n199TTBUS7_DesUsuario
               }
               , new Object[] {
               T000625_A33TTBUS7_Pos, T000625_A39TTBUS7_CodUsuario
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000629_A199TTBUS7_DesUsuario, T000629_n199TTBUS7_DesUsuario
               }
               , new Object[] {
               T000630_A33TTBUS7_Pos, T000630_A39TTBUS7_CodUsuario
               }
            }
         );
      }

      private short nIsMod_8 ;
      private short wcpOAV9TTBUS3_Pos ;
      private short GxWebError ;
      private short A33TTBUS7_Pos ;
      private short nRC_Gridttbus007_permisos ;
      private short nGXsfl_60_idx=1 ;
      private short AV9TTBUS3_Pos ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short subGridttbus007_permisos_Backcolorstyle ;
      private short A51TTBUS7_RespAux ;
      private short subGridttbus007_permisos_Collapsed ;
      private short nBlankRcdCount8 ;
      private short nRcdExists_8 ;
      private short RcdFound8 ;
      private short nBlankRcdUsr8 ;
      private short Z33TTBUS7_Pos ;
      private short RcdFound7 ;
      private short nRcdDeleted_8 ;
      private short Z51TTBUS7_RespAux ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short subGridttbus007_permisos_Backstyle ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int edtTTBUS7_Pos_Enabled ;
      private int imgprompt_33_Visible ;
      private int edtTTBUS7_Des_Enabled ;
      private int edtTTBUS7_CodResp_Enabled ;
      private int imgprompt_35_Visible ;
      private int edtTTBUS7_DesResp_Enabled ;
      private int edtTTBUS7_CodUsuario_Enabled ;
      private int edtTTBUS7_DesUsuario_Enabled ;
      private int fRowAdded ;
      private int imgBtn_first_Visible ;
      private int imgBtn_first_separator_Visible ;
      private int imgBtn_previous_Visible ;
      private int imgBtn_previous_separator_Visible ;
      private int imgBtn_next_Visible ;
      private int imgBtn_next_separator_Visible ;
      private int imgBtn_last_Visible ;
      private int imgBtn_last_separator_Visible ;
      private int imgBtn_select_Visible ;
      private int imgBtn_select_separator_Visible ;
      private int imgBtn_enter2_Visible ;
      private int imgBtn_enter2_Enabled ;
      private int imgBtn_enter2_separator_Visible ;
      private int imgBtn_cancel2_Visible ;
      private int imgBtn_cancel2_separator_Visible ;
      private int imgBtn_delete2_Visible ;
      private int imgBtn_delete2_Enabled ;
      private int imgBtn_delete2_separator_Visible ;
      private int GRIDTTBUS007_PERMISOS_nFirstRecordOnPage ;
      private int subGridttbus007_permisos_Backcolor ;
      private int subGridttbus007_permisos_Allbackcolor ;
      private int imgprompt_39_Visible ;
      private int defedtTTBUS7_CodUsuario_Enabled ;
      private int idxLst ;
      private String sPrefix ;
      private String sGXsfl_60_idx="0001" ;
      private String wcpOGx_mode ;
      private String wcpOAV7SISTEMA ;
      private String wcpOAV8USUARIO ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String A35TTBUS7_CodResp ;
      private String A39TTBUS7_CodUsuario ;
      private String Gx_mode ;
      private String AV7SISTEMA ;
      private String AV8USUARIO ;
      private String GXCCtl ;
      private String chkTTBUS7_RespAux_Internalname ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtTTBUS7_Pos_Internalname ;
      private String sStyleString ;
      private String tblTablemain_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String grpGroupdata_Internalname ;
      private String tblTable1_Internalname ;
      private String TempTags ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockttbus7_pos_Internalname ;
      private String lblTextblockttbus7_pos_Jsonclick ;
      private String edtTTBUS7_Pos_Jsonclick ;
      private String imgprompt_33_Internalname ;
      private String imgprompt_33_Link ;
      private String lblTextblockttbus7_des_Internalname ;
      private String lblTextblockttbus7_des_Jsonclick ;
      private String edtTTBUS7_Des_Internalname ;
      private String A34TTBUS7_Des ;
      private String edtTTBUS7_Des_Jsonclick ;
      private String lblTextblockttbus7_codresp_Internalname ;
      private String lblTextblockttbus7_codresp_Jsonclick ;
      private String edtTTBUS7_CodResp_Internalname ;
      private String edtTTBUS7_CodResp_Jsonclick ;
      private String imgprompt_35_Internalname ;
      private String imgprompt_35_Link ;
      private String lblTextblockttbus7_desresp_Internalname ;
      private String lblTextblockttbus7_desresp_Jsonclick ;
      private String edtTTBUS7_DesResp_Internalname ;
      private String A36TTBUS7_DesResp ;
      private String edtTTBUS7_DesResp_Jsonclick ;
      private String A199TTBUS7_DesUsuario ;
      private String sMode8 ;
      private String edtTTBUS7_CodUsuario_Internalname ;
      private String edtTTBUS7_DesUsuario_Internalname ;
      private String tblTable3_Internalname ;
      private String lblTitlepermisos_Internalname ;
      private String lblTitlepermisos_Jsonclick ;
      private String tblTabletoolbar_Internalname ;
      private String imgBtn_first_Internalname ;
      private String imgBtn_first_Jsonclick ;
      private String imgBtn_first_separator_Internalname ;
      private String imgBtn_first_separator_Jsonclick ;
      private String imgBtn_previous_Internalname ;
      private String imgBtn_previous_Jsonclick ;
      private String imgBtn_previous_separator_Internalname ;
      private String imgBtn_previous_separator_Jsonclick ;
      private String imgBtn_next_Internalname ;
      private String imgBtn_next_Jsonclick ;
      private String imgBtn_next_separator_Internalname ;
      private String imgBtn_next_separator_Jsonclick ;
      private String imgBtn_last_Internalname ;
      private String imgBtn_last_Jsonclick ;
      private String imgBtn_last_separator_Internalname ;
      private String imgBtn_last_separator_Jsonclick ;
      private String imgBtn_select_Internalname ;
      private String imgBtn_select_Jsonclick ;
      private String imgBtn_select_separator_Internalname ;
      private String imgBtn_select_separator_Jsonclick ;
      private String imgBtn_enter2_Internalname ;
      private String imgBtn_enter2_Jsonclick ;
      private String imgBtn_enter2_separator_Internalname ;
      private String imgBtn_enter2_separator_Jsonclick ;
      private String imgBtn_cancel2_Internalname ;
      private String imgBtn_cancel2_Jsonclick ;
      private String imgBtn_cancel2_separator_Internalname ;
      private String imgBtn_cancel2_separator_Jsonclick ;
      private String imgBtn_delete2_Internalname ;
      private String imgBtn_delete2_Jsonclick ;
      private String imgBtn_delete2_separator_Internalname ;
      private String imgBtn_delete2_separator_Jsonclick ;
      private String Z35TTBUS7_CodResp ;
      private String sMode7 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String Z39TTBUS7_CodUsuario ;
      private String Z34TTBUS7_Des ;
      private String Z36TTBUS7_DesResp ;
      private String Z199TTBUS7_DesUsuario ;
      private String imgprompt_39_Internalname ;
      private String subGridttbus007_permisos_Class ;
      private String subGridttbus007_permisos_Linesclass ;
      private String imgprompt_39_Link ;
      private String ROClassString ;
      private String edtTTBUS7_CodUsuario_Jsonclick ;
      private String edtTTBUS7_DesUsuario_Jsonclick ;
      private String GXt_char4 ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char6 ;
      private String GXt_char5 ;
      private String subGridttbus007_permisos_Internalname ;
      private String GXt_char7 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool n34TTBUS7_Des ;
      private bool n36TTBUS7_DesResp ;
      private bool n199TTBUS7_DesUsuario ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Gridttbus007_permisosContainer ;
      private GXWebRow Gridttbus007_permisosRow ;
      private GXWebColumn Gridttbus007_permisosColumn ;
      private IGxDataStore dsDefault ;
      private short aP0_TTBUS3_Pos ;
      private String aP1_Gx_mode ;
      private String aP2_SISTEMA ;
      private String aP3_USUARIO ;
      private GXCheckbox chkTTBUS7_RespAux ;
      private IDataStoreProvider pr_default ;
      private String[] T00067_A34TTBUS7_Des ;
      private bool[] T00067_n34TTBUS7_Des ;
      private String[] T00069_A34TTBUS7_Des ;
      private bool[] T00069_n34TTBUS7_Des ;
      private String[] T00069_A36TTBUS7_DesResp ;
      private bool[] T00069_n36TTBUS7_DesResp ;
      private short[] T00069_A33TTBUS7_Pos ;
      private String[] T00069_A35TTBUS7_CodResp ;
      private String[] T00068_A36TTBUS7_DesResp ;
      private bool[] T00068_n36TTBUS7_DesResp ;
      private String[] T000610_A34TTBUS7_Des ;
      private bool[] T000610_n34TTBUS7_Des ;
      private String[] T000611_A36TTBUS7_DesResp ;
      private bool[] T000611_n36TTBUS7_DesResp ;
      private short[] T000612_A33TTBUS7_Pos ;
      private short[] T00066_A33TTBUS7_Pos ;
      private String[] T00066_A35TTBUS7_CodResp ;
      private short[] T000613_A33TTBUS7_Pos ;
      private short[] T000614_A33TTBUS7_Pos ;
      private short[] T000615_A33TTBUS7_Pos ;
      private String[] T000615_A35TTBUS7_CodResp ;
      private String[] T000619_A34TTBUS7_Des ;
      private bool[] T000619_n34TTBUS7_Des ;
      private String[] T000620_A36TTBUS7_DesResp ;
      private bool[] T000620_n36TTBUS7_DesResp ;
      private int[] T000621_A11TTBUS_Id ;
      private short[] T000622_A33TTBUS7_Pos ;
      private short[] T000623_A33TTBUS7_Pos ;
      private String[] T000623_A199TTBUS7_DesUsuario ;
      private bool[] T000623_n199TTBUS7_DesUsuario ;
      private short[] T000623_A51TTBUS7_RespAux ;
      private String[] T000623_A39TTBUS7_CodUsuario ;
      private String[] T00064_A199TTBUS7_DesUsuario ;
      private bool[] T00064_n199TTBUS7_DesUsuario ;
      private String[] T000624_A199TTBUS7_DesUsuario ;
      private bool[] T000624_n199TTBUS7_DesUsuario ;
      private short[] T000625_A33TTBUS7_Pos ;
      private String[] T000625_A39TTBUS7_CodUsuario ;
      private short[] T00063_A33TTBUS7_Pos ;
      private short[] T00063_A51TTBUS7_RespAux ;
      private String[] T00063_A39TTBUS7_CodUsuario ;
      private short[] T00062_A33TTBUS7_Pos ;
      private short[] T00062_A51TTBUS7_RespAux ;
      private String[] T00062_A39TTBUS7_CodUsuario ;
      private String[] T000629_A199TTBUS7_DesUsuario ;
      private bool[] T000629_n199TTBUS7_DesUsuario ;
      private short[] T000630_A33TTBUS7_Pos ;
      private String[] T000630_A39TTBUS7_CodUsuario ;
      private short[] T00065_A33TTBUS7_Pos ;
      private String[] T00065_A35TTBUS7_CodResp ;
      private GXWebForm Form ;
   }

   public class ttbus007__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new ForEachCursor(def[7])
         ,new ForEachCursor(def[8])
         ,new ForEachCursor(def[9])
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new UpdateCursor(def[14])
         ,new UpdateCursor(def[15])
         ,new UpdateCursor(def[16])
         ,new ForEachCursor(def[17])
         ,new ForEachCursor(def[18])
         ,new ForEachCursor(def[19])
         ,new ForEachCursor(def[20])
         ,new ForEachCursor(def[21])
         ,new ForEachCursor(def[22])
         ,new ForEachCursor(def[23])
         ,new UpdateCursor(def[24])
         ,new UpdateCursor(def[25])
         ,new UpdateCursor(def[26])
         ,new ForEachCursor(def[27])
         ,new ForEachCursor(def[28])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00065 ;
          prmT00065 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT00069 ;
          prmT00069 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT00067 ;
          prmT00067 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT00068 ;
          prmT00068 = new Object[] {
          new Object[] {"@TTBUS7_CodResp",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000610 ;
          prmT000610 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000611 ;
          prmT000611 = new Object[] {
          new Object[] {"@TTBUS7_CodResp",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000612 ;
          prmT000612 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT00066 ;
          prmT00066 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000613 ;
          prmT000613 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000614 ;
          prmT000614 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000615 ;
          prmT000615 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000616 ;
          prmT000616 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TTBUS7_CodResp",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000617 ;
          prmT000617 = new Object[] {
          new Object[] {"@TTBUS7_CodResp",SqlDbType.Char,16,0} ,
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000618 ;
          prmT000618 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000621 ;
          prmT000621 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000622 ;
          prmT000622 = new Object[] {
          } ;
          Object[] prmT000623 ;
          prmT000623 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TTBUS7_CodUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT00064 ;
          prmT00064 = new Object[] {
          new Object[] {"@TTBUS7_CodUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000624 ;
          prmT000624 = new Object[] {
          new Object[] {"@TTBUS7_CodUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000625 ;
          prmT000625 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TTBUS7_CodUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT00063 ;
          prmT00063 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TTBUS7_CodUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT00062 ;
          prmT00062 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TTBUS7_CodUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000626 ;
          prmT000626 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TTBUS7_RespAux",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TTBUS7_CodUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000627 ;
          prmT000627 = new Object[] {
          new Object[] {"@TTBUS7_RespAux",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TTBUS7_CodUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000628 ;
          prmT000628 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TTBUS7_CodUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000630 ;
          prmT000630 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000619 ;
          prmT000619 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000620 ;
          prmT000620 = new Object[] {
          new Object[] {"@TTBUS7_CodResp",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000629 ;
          prmT000629 = new Object[] {
          new Object[] {"@TTBUS7_CodUsuario",SqlDbType.Char,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00062", "SELECT [TTBUS7_Pos] AS TTBUS7_Pos, [TTBUS7_RespAux], [TTBUS7_CodUsuario] AS TTBUS7_CodUsuario FROM [TTBUS007Permisos] WITH (UPDLOCK) WHERE [TTBUS7_Pos] = @TTBUS7_Pos AND [TTBUS7_CodUsuario] = @TTBUS7_CodUsuario ",true, GxErrorMask.GX_NOMASK, false, this,prmT00062,1,0,true,false )
             ,new CursorDef("T00063", "SELECT [TTBUS7_Pos] AS TTBUS7_Pos, [TTBUS7_RespAux], [TTBUS7_CodUsuario] AS TTBUS7_CodUsuario FROM [TTBUS007Permisos] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @TTBUS7_Pos AND [TTBUS7_CodUsuario] = @TTBUS7_CodUsuario ",true, GxErrorMask.GX_NOMASK, false, this,prmT00063,1,0,true,false )
             ,new CursorDef("T00064", "SELECT [USU_DES] AS TTBUS7_DesUsuario FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS7_CodUsuario ",true, GxErrorMask.GX_NOMASK, false, this,prmT00064,1,0,true,false )
             ,new CursorDef("T00065", "SELECT [TTBUS7_Pos] AS TTBUS7_Pos, [TTBUS7_CodResp] AS TTBUS7_CodResp FROM [TTBUS007] WITH (UPDLOCK) WHERE [TTBUS7_Pos] = @TTBUS7_Pos ",true, GxErrorMask.GX_NOMASK, false, this,prmT00065,1,0,true,false )
             ,new CursorDef("T00066", "SELECT [TTBUS7_Pos] AS TTBUS7_Pos, [TTBUS7_CodResp] AS TTBUS7_CodResp FROM [TTBUS007] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @TTBUS7_Pos ",true, GxErrorMask.GX_NOMASK, false, this,prmT00066,1,0,true,false )
             ,new CursorDef("T00067", "SELECT [W53DES] AS TTBUS7_Des FROM [T53FPOS] WITH (NOLOCK) WHERE [W53POS] = @TTBUS7_Pos ",true, GxErrorMask.GX_NOMASK, false, this,prmT00067,1,0,true,false )
             ,new CursorDef("T00068", "SELECT [USU_DES] AS TTBUS7_DesResp FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS7_CodResp ",true, GxErrorMask.GX_NOMASK, false, this,prmT00068,1,0,true,false )
             ,new CursorDef("T00069", "SELECT T2.[W53DES] AS TTBUS7_Des, T3.[USU_DES] AS TTBUS7_DesResp, TM1.[TTBUS7_Pos] AS TTBUS7_Pos, TM1.[TTBUS7_CodResp] AS TTBUS7_CodResp FROM (([TTBUS007] TM1 WITH (NOLOCK) INNER JOIN [T53FPOS] T2 WITH (NOLOCK) ON T2.[W53POS] = TM1.[TTBUS7_Pos]) INNER JOIN [SEG002] T3 WITH (NOLOCK) ON T3.[USU_COD] = TM1.[TTBUS7_CodResp]) WHERE TM1.[TTBUS7_Pos] = @TTBUS7_Pos ORDER BY TM1.[TTBUS7_Pos]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00069,100,0,true,false )
             ,new CursorDef("T000610", "SELECT [W53DES] AS TTBUS7_Des FROM [T53FPOS] WITH (NOLOCK) WHERE [W53POS] = @TTBUS7_Pos ",true, GxErrorMask.GX_NOMASK, false, this,prmT000610,1,0,true,false )
             ,new CursorDef("T000611", "SELECT [USU_DES] AS TTBUS7_DesResp FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS7_CodResp ",true, GxErrorMask.GX_NOMASK, false, this,prmT000611,1,0,true,false )
             ,new CursorDef("T000612", "SELECT [TTBUS7_Pos] AS TTBUS7_Pos FROM [TTBUS007] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @TTBUS7_Pos  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000612,1,0,true,false )
             ,new CursorDef("T000613", "SELECT TOP 1 [TTBUS7_Pos] AS TTBUS7_Pos FROM [TTBUS007] WITH (NOLOCK) WHERE ( [TTBUS7_Pos] > @TTBUS7_Pos) ORDER BY [TTBUS7_Pos]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000613,1,0,true,true )
             ,new CursorDef("T000614", "SELECT TOP 1 [TTBUS7_Pos] AS TTBUS7_Pos FROM [TTBUS007] WITH (NOLOCK) WHERE ( [TTBUS7_Pos] < @TTBUS7_Pos) ORDER BY [TTBUS7_Pos] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000614,1,0,true,true )
             ,new CursorDef("T000615", "SELECT [TTBUS7_Pos] AS TTBUS7_Pos, [TTBUS7_CodResp] AS TTBUS7_CodResp FROM [TTBUS007] WITH (UPDLOCK) WHERE [TTBUS7_Pos] = @TTBUS7_Pos ",true, GxErrorMask.GX_NOMASK, false, this,prmT000615,1,0,true,false )
             ,new CursorDef("T000616", "INSERT INTO [TTBUS007] ([TTBUS7_Pos], [TTBUS7_CodResp]) VALUES (@TTBUS7_Pos, @TTBUS7_CodResp)", GxErrorMask.GX_NOMASK,prmT000616)
             ,new CursorDef("T000617", "UPDATE [TTBUS007] SET [TTBUS7_CodResp]=@TTBUS7_CodResp  WHERE [TTBUS7_Pos] = @TTBUS7_Pos", GxErrorMask.GX_NOMASK,prmT000617)
             ,new CursorDef("T000618", "DELETE FROM [TTBUS007]  WHERE [TTBUS7_Pos] = @TTBUS7_Pos", GxErrorMask.GX_NOMASK,prmT000618)
             ,new CursorDef("T000619", "SELECT [W53DES] AS TTBUS7_Des FROM [T53FPOS] WITH (NOLOCK) WHERE [W53POS] = @TTBUS7_Pos ",true, GxErrorMask.GX_NOMASK, false, this,prmT000619,1,0,true,false )
             ,new CursorDef("T000620", "SELECT [USU_DES] AS TTBUS7_DesResp FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS7_CodResp ",true, GxErrorMask.GX_NOMASK, false, this,prmT000620,1,0,true,false )
             ,new CursorDef("T000621", "SELECT TOP 1 [TTBUS_Id] FROM [TTBUS000] WITH (NOLOCK) WHERE [TTBUS_CodPosicion] = @TTBUS7_Pos ",true, GxErrorMask.GX_NOMASK, false, this,prmT000621,1,0,true,true )
             ,new CursorDef("T000622", "SELECT [TTBUS7_Pos] AS TTBUS7_Pos FROM [TTBUS007] WITH (NOLOCK) ORDER BY [TTBUS7_Pos]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000622,100,0,true,false )
             ,new CursorDef("T000623", "SELECT T1.[TTBUS7_Pos] AS TTBUS7_Pos, T2.[USU_DES] AS TTBUS7_DesUsuario, T1.[TTBUS7_RespAux], T1.[TTBUS7_CodUsuario] AS TTBUS7_CodUsuario FROM ([TTBUS007Permisos] T1 WITH (NOLOCK) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = T1.[TTBUS7_CodUsuario]) WHERE T1.[TTBUS7_Pos] = @TTBUS7_Pos and T1.[TTBUS7_CodUsuario] = @TTBUS7_CodUsuario ORDER BY T1.[TTBUS7_Pos], T1.[TTBUS7_CodUsuario] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000623,11,0,true,false )
             ,new CursorDef("T000624", "SELECT [USU_DES] AS TTBUS7_DesUsuario FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS7_CodUsuario ",true, GxErrorMask.GX_NOMASK, false, this,prmT000624,1,0,true,false )
             ,new CursorDef("T000625", "SELECT [TTBUS7_Pos] AS TTBUS7_Pos, [TTBUS7_CodUsuario] AS TTBUS7_CodUsuario FROM [TTBUS007Permisos] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @TTBUS7_Pos AND [TTBUS7_CodUsuario] = @TTBUS7_CodUsuario ",true, GxErrorMask.GX_NOMASK, false, this,prmT000625,1,0,true,false )
             ,new CursorDef("T000626", "INSERT INTO [TTBUS007Permisos] ([TTBUS7_Pos], [TTBUS7_RespAux], [TTBUS7_CodUsuario]) VALUES (@TTBUS7_Pos, @TTBUS7_RespAux, @TTBUS7_CodUsuario)", GxErrorMask.GX_NOMASK,prmT000626)
             ,new CursorDef("T000627", "UPDATE [TTBUS007Permisos] SET [TTBUS7_RespAux]=@TTBUS7_RespAux  WHERE [TTBUS7_Pos] = @TTBUS7_Pos AND [TTBUS7_CodUsuario] = @TTBUS7_CodUsuario", GxErrorMask.GX_NOMASK,prmT000627)
             ,new CursorDef("T000628", "DELETE FROM [TTBUS007Permisos]  WHERE [TTBUS7_Pos] = @TTBUS7_Pos AND [TTBUS7_CodUsuario] = @TTBUS7_CodUsuario", GxErrorMask.GX_NOMASK,prmT000628)
             ,new CursorDef("T000629", "SELECT [USU_DES] AS TTBUS7_DesUsuario FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS7_CodUsuario ",true, GxErrorMask.GX_NOMASK, false, this,prmT000629,1,0,true,false )
             ,new CursorDef("T000630", "SELECT [TTBUS7_Pos] AS TTBUS7_Pos, [TTBUS7_CodUsuario] AS TTBUS7_CodUsuario FROM [TTBUS007Permisos] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @TTBUS7_Pos ORDER BY [TTBUS7_Pos], [TTBUS7_CodUsuario] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000630,11,0,true,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 16) ;
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 16) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
                break;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((short[]) buf[4])[0] = rslt.getShort(3) ;
                ((String[]) buf[5])[0] = rslt.getString(4, 16) ;
                break;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 10 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 11 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 12 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
                break;
             case 17 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 18 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 19 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 20 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 21 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((String[]) buf[4])[0] = rslt.getString(4, 16) ;
                break;
             case 22 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 23 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
                break;
             case 27 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 28 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 15 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 16 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 17 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 18 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 19 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 21 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 22 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 23 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 24 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                break;
             case 25 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                break;
             case 26 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 27 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 28 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
       }
    }

 }

}
