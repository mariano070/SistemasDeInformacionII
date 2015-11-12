/*
               File: TTBUS020
        Description: Mensajes de Administrador de Cambio de Posiciones
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 2/26/2014 11:47:24.15
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
   public class ttbus020 : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else
         {
            if ( ! IsValidAjaxCall( false) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxfirstwebparm = gxfirstwebparm_bkp ;
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Mensajes de Administrador de Cambio de Posiciones", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtTTBUS20_IdBien_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Modern");
      }

      public ttbus020( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ttbus020( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( )
      {
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
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
            wb_table1_2_0D13( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_0D13e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_0D13( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_0D13( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_0D13e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Mensajes de Administrador de Cambio de Posiciones"+"</legend>") ;
            wb_table3_27_0D13( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_0D13e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0D13e( true) ;
         }
         else
         {
            wb_table1_2_0D13e( false) ;
         }
      }

      protected void wb_table3_27_0D13( bool wbgen )
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
            wb_table4_33_0D13( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_0D13e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_enter_Internalname, "Confirmar", "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "rounded", 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "HLP_TTBUS020.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 77,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "HLP_TTBUS020.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_delete_Internalname, "Eliminar", "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "rounded", 5, bttBtn_delete_Jsonclick, "EDELETE.", TempTags, "", "", "HLP_TTBUS020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_0D13e( true) ;
         }
         else
         {
            wb_table3_27_0D13e( false) ;
         }
      }

      protected void wb_table4_33_0D13( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus20_idbien_Internalname, 1, 1, 0, "de uso", "", "", "", 0, lblTextblockttbus20_idbien_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS20_IdBien_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A223TTBUS20_IdBien), 8, 0, ",", "")), "", 8, "chr", 1, "row", 8, 1, edtTTBUS20_IdBien_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A223TTBUS20_IdBien), "ZZZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(38);\"", 0, edtTTBUS20_IdBien_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TTBUS020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus20_descripcion_Internalname, 1, 1, 0, "de uso", "", "", "", 0, lblTextblockttbus20_descripcion_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS20_Descripcion_Internalname, StringUtil.RTrim( A224TTBUS20_Descripcion), "", 50, "chr", 1, "row", 50, 1, edtTTBUS20_Descripcion_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A224TTBUS20_Descripcion, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(43);\"", 0, edtTTBUS20_Descripcion_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TTBUS020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus20_mensaje_Internalname, 1, 1, 0, "de posición", "", "", "", 0, lblTextblockttbus20_mensaje_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS20_Mensaje_Internalname, StringUtil.RTrim( A218TTBUS20_Mensaje), "", 80, "chr", 1, "row", 100, 1, edtTTBUS20_Mensaje_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A218TTBUS20_Mensaje, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(48);\"", 0, edtTTBUS20_Mensaje_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TTBUS020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus20_motivoenvio_Internalname, 1, 1, 0, "de envío", "", "", "", 0, lblTextblockttbus20_motivoenvio_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS20_MotivoEnvio_Internalname, StringUtil.RTrim( A220TTBUS20_MotivoEnvio), "", 80, "chr", 1, "row", 100, 1, edtTTBUS20_MotivoEnvio_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A220TTBUS20_MotivoEnvio, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(53);\"", 0, edtTTBUS20_MotivoEnvio_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TTBUS020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus20_observaciones_Internalname, 1, 1, 0, "Observaciones", "", "", "", 0, lblTextblockttbus20_observaciones_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtTTBUS20_Observaciones_Internalname, StringUtil.RTrim( A221TTBUS20_Observaciones), 1, edtTTBUS20_Observaciones_Enabled, 0, 80, "chr", 7, "row", StyleString, ClassString, "500", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(58);\"", -1, 0, "", "", true, "HLP_TTBUS020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus20_estacion_Internalname, 1, 1, 0, "de trabajo", "", "", "", 0, lblTextblockttbus20_estacion_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS20_Estacion_Internalname, StringUtil.RTrim( A219TTBUS20_Estacion), "", 20, "chr", 1, "row", 20, 1, edtTTBUS20_Estacion_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A219TTBUS20_Estacion, "XXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(63);\"", 0, edtTTBUS20_Estacion_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TTBUS020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus20_usuario_Internalname, 1, 1, 0, "Usuario", "", "", "", 0, lblTextblockttbus20_usuario_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS20_Usuario_Internalname, StringUtil.RTrim( A225TTBUS20_Usuario), "", 16, "chr", 1, "row", 16, 1, edtTTBUS20_Usuario_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A225TTBUS20_Usuario, "XXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(68);\"", 0, edtTTBUS20_Usuario_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TTBUS020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus20_plazorecepcion_Internalname, 1, 1, 0, "un bien", "", "", "", 0, lblTextblockttbus20_plazorecepcion_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtTTBUS20_PlazoRecepcion_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS20_PlazoRecepcion_Internalname, context.localUtil.Format(A222TTBUS20_PlazoRecepcion, "99/99/9999"), "", 10, "chr", 1, "row", 10, 1, edtTTBUS20_PlazoRecepcion_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A222TTBUS20_PlazoRecepcion, "99/99/9999"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(73);\"", 0, edtTTBUS20_PlazoRecepcion_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TTBUS020.htm");
            GxWebStd.gx_bitmap( context, edtTTBUS20_PlazoRecepcion_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(edtTTBUS20_PlazoRecepcion_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_TTBUS020.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_0D13e( true) ;
         }
         else
         {
            wb_table4_33_0D13e( false) ;
         }
      }

      protected void wb_table2_5_0D13( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, "", context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Modern"), "Modern", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS020.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS020.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, "", context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Modern"), "Modern", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS020.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS020.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, "", context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Modern"), "Modern", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS020.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS020.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, "", context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Modern"), "Modern", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS020.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS020.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, "", context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Modern"), "Modern", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00d0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"TTBUS20_IDBIEN"+"'), id:'"+"TTBUS20_IDBIEN"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");"+"return false;", "HLP_TTBUS020.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00d0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"TTBUS20_IDBIEN"+"'), id:'"+"TTBUS20_IDBIEN"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");"+"return false;", "HLP_TTBUS020.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, "", context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Modern"), "Modern", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS020.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS020.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, "", context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Modern"), "Modern", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS020.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS020.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, "", context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Modern"), "Modern", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS020.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS020.htm");
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
            wb_table2_5_0D13e( true) ;
         }
         else
         {
            wb_table2_5_0D13e( false) ;
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
               if ( ! context.localUtil.VCNumber( cgiGet( edtTTBUS20_IdBien_Internalname), "ZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtTTBUS20_IdBien_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtTTBUS20_IdBien_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "TTBUS20_IDBIEN");
                  AnyError = 1 ;
                  GX_FocusControl = edtTTBUS20_IdBien_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A223TTBUS20_IdBien = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A223TTBUS20_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A223TTBUS20_IdBien), 8, 0)));
               }
               else
               {
                  A223TTBUS20_IdBien = (int)(context.localUtil.CToN( cgiGet( edtTTBUS20_IdBien_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A223TTBUS20_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A223TTBUS20_IdBien), 8, 0)));
               }
               A224TTBUS20_Descripcion = cgiGet( edtTTBUS20_Descripcion_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A224TTBUS20_Descripcion", A224TTBUS20_Descripcion);
               A218TTBUS20_Mensaje = cgiGet( edtTTBUS20_Mensaje_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A218TTBUS20_Mensaje", A218TTBUS20_Mensaje);
               A220TTBUS20_MotivoEnvio = cgiGet( edtTTBUS20_MotivoEnvio_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A220TTBUS20_MotivoEnvio", A220TTBUS20_MotivoEnvio);
               A221TTBUS20_Observaciones = cgiGet( edtTTBUS20_Observaciones_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A221TTBUS20_Observaciones", A221TTBUS20_Observaciones);
               A219TTBUS20_Estacion = cgiGet( edtTTBUS20_Estacion_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A219TTBUS20_Estacion", A219TTBUS20_Estacion);
               A225TTBUS20_Usuario = cgiGet( edtTTBUS20_Usuario_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A225TTBUS20_Usuario", A225TTBUS20_Usuario);
               if ( context.localUtil.VCDate( cgiGet( edtTTBUS20_PlazoRecepcion_Internalname), 4) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Plazo límite recepción de un bien"}), 1, "TTBUS20_PLAZORECEPCION");
                  AnyError = 1 ;
                  GX_FocusControl = edtTTBUS20_PlazoRecepcion_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A222TTBUS20_PlazoRecepcion = DateTime.MinValue ;
                  n222TTBUS20_PlazoRecepcion = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A222TTBUS20_PlazoRecepcion", context.localUtil.Format(A222TTBUS20_PlazoRecepcion, "99/99/9999"));
               }
               else
               {
                  A222TTBUS20_PlazoRecepcion = context.localUtil.CToD( cgiGet( edtTTBUS20_PlazoRecepcion_Internalname), 4) ;
                  n222TTBUS20_PlazoRecepcion = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A222TTBUS20_PlazoRecepcion", context.localUtil.Format(A222TTBUS20_PlazoRecepcion, "99/99/9999"));
               }
               n222TTBUS20_PlazoRecepcion = ((DateTime.MinValue==A222TTBUS20_PlazoRecepcion) ? true : false) ;
               /* Read saved values. */
               Z223TTBUS20_IdBien = (int)(context.localUtil.CToN( cgiGet( "Z223TTBUS20_IdBien"), ",", ".")) ;
               Z224TTBUS20_Descripcion = cgiGet( "Z224TTBUS20_Descripcion") ;
               Z218TTBUS20_Mensaje = cgiGet( "Z218TTBUS20_Mensaje") ;
               Z220TTBUS20_MotivoEnvio = cgiGet( "Z220TTBUS20_MotivoEnvio") ;
               Z221TTBUS20_Observaciones = cgiGet( "Z221TTBUS20_Observaciones") ;
               Z219TTBUS20_Estacion = cgiGet( "Z219TTBUS20_Estacion") ;
               Z225TTBUS20_Usuario = cgiGet( "Z225TTBUS20_Usuario") ;
               Z222TTBUS20_PlazoRecepcion = context.localUtil.CToD( cgiGet( "Z222TTBUS20_PlazoRecepcion"), 0) ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", ".")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", ".")) ;
               Gx_mode = cgiGet( "Mode") ;
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
                  A223TTBUS20_IdBien = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A223TTBUS20_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A223TTBUS20_IdBien), 8, 0)));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  disable_std_buttons_dsp( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  Gx_mode = "INS" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  standaloneModal( ) ;
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
                           btn_first( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "PREVIOUS") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_previous( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_next( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_last( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "SELECT") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_select( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DELETE") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_delete( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                        {
                           context.wbHandled = 1 ;
                           AfterKeyLoadScreen( ) ;
                        }
                     }
                     else
                     {
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
               InitAll0D13( ) ;
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
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            imgBtn_delete2_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         }
      }

      protected void disable_std_buttons_dsp( )
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
         edtTTBUS20_IdBien_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS20_IdBien_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS20_IdBien_Enabled), 5, 0)));
         edtTTBUS20_Descripcion_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS20_Descripcion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS20_Descripcion_Enabled), 5, 0)));
         edtTTBUS20_Mensaje_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS20_Mensaje_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS20_Mensaje_Enabled), 5, 0)));
         edtTTBUS20_MotivoEnvio_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS20_MotivoEnvio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS20_MotivoEnvio_Enabled), 5, 0)));
         edtTTBUS20_Observaciones_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS20_Observaciones_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS20_Observaciones_Enabled), 5, 0)));
         edtTTBUS20_Estacion_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS20_Estacion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS20_Estacion_Enabled), 5, 0)));
         edtTTBUS20_Usuario_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS20_Usuario_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS20_Usuario_Enabled), 5, 0)));
         edtTTBUS20_PlazoRecepcion_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS20_PlazoRecepcion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS20_PlazoRecepcion_Enabled), 5, 0)));
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

      protected void ResetCaption0D0( )
      {
      }

      protected void ZM0D13( short GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z224TTBUS20_Descripcion = T000D3_A224TTBUS20_Descripcion[0] ;
               Z218TTBUS20_Mensaje = T000D3_A218TTBUS20_Mensaje[0] ;
               Z220TTBUS20_MotivoEnvio = T000D3_A220TTBUS20_MotivoEnvio[0] ;
               Z221TTBUS20_Observaciones = T000D3_A221TTBUS20_Observaciones[0] ;
               Z219TTBUS20_Estacion = T000D3_A219TTBUS20_Estacion[0] ;
               Z225TTBUS20_Usuario = T000D3_A225TTBUS20_Usuario[0] ;
               Z222TTBUS20_PlazoRecepcion = T000D3_A222TTBUS20_PlazoRecepcion[0] ;
            }
            else
            {
               Z224TTBUS20_Descripcion = A224TTBUS20_Descripcion ;
               Z218TTBUS20_Mensaje = A218TTBUS20_Mensaje ;
               Z220TTBUS20_MotivoEnvio = A220TTBUS20_MotivoEnvio ;
               Z221TTBUS20_Observaciones = A221TTBUS20_Observaciones ;
               Z219TTBUS20_Estacion = A219TTBUS20_Estacion ;
               Z225TTBUS20_Usuario = A225TTBUS20_Usuario ;
               Z222TTBUS20_PlazoRecepcion = A222TTBUS20_PlazoRecepcion ;
            }
         }
         if ( GX_JID == -2 )
         {
            Z223TTBUS20_IdBien = A223TTBUS20_IdBien ;
            Z224TTBUS20_Descripcion = A224TTBUS20_Descripcion ;
            Z218TTBUS20_Mensaje = A218TTBUS20_Mensaje ;
            Z220TTBUS20_MotivoEnvio = A220TTBUS20_MotivoEnvio ;
            Z221TTBUS20_Observaciones = A221TTBUS20_Observaciones ;
            Z219TTBUS20_Estacion = A219TTBUS20_Estacion ;
            Z225TTBUS20_Usuario = A225TTBUS20_Usuario ;
            Z222TTBUS20_PlazoRecepcion = A222TTBUS20_PlazoRecepcion ;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
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
      }

      protected void Load0D13( )
      {
         /* Using cursor T000D4 */
         pr_default.execute(2, new Object[] {A223TTBUS20_IdBien});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound13 = 1 ;
            A224TTBUS20_Descripcion = T000D4_A224TTBUS20_Descripcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A224TTBUS20_Descripcion", A224TTBUS20_Descripcion);
            A218TTBUS20_Mensaje = T000D4_A218TTBUS20_Mensaje[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A218TTBUS20_Mensaje", A218TTBUS20_Mensaje);
            A220TTBUS20_MotivoEnvio = T000D4_A220TTBUS20_MotivoEnvio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A220TTBUS20_MotivoEnvio", A220TTBUS20_MotivoEnvio);
            A221TTBUS20_Observaciones = T000D4_A221TTBUS20_Observaciones[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A221TTBUS20_Observaciones", A221TTBUS20_Observaciones);
            A219TTBUS20_Estacion = T000D4_A219TTBUS20_Estacion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A219TTBUS20_Estacion", A219TTBUS20_Estacion);
            A225TTBUS20_Usuario = T000D4_A225TTBUS20_Usuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A225TTBUS20_Usuario", A225TTBUS20_Usuario);
            A222TTBUS20_PlazoRecepcion = T000D4_A222TTBUS20_PlazoRecepcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A222TTBUS20_PlazoRecepcion", context.localUtil.Format(A222TTBUS20_PlazoRecepcion, "99/99/9999"));
            n222TTBUS20_PlazoRecepcion = T000D4_n222TTBUS20_PlazoRecepcion[0] ;
            ZM0D13( -2) ;
         }
         pr_default.close(2);
         OnLoadActions0D13( ) ;
      }

      protected void OnLoadActions0D13( )
      {
      }

      protected void CheckExtendedTable0D13( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         if ( ! ( (DateTime.MinValue==A222TTBUS20_PlazoRecepcion) || ( A222TTBUS20_PlazoRecepcion >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Plazo límite recepción de un bien fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
      }

      protected void CloseExtendedTableCursors0D13( )
      {
      }

      protected void enableDisable( )
      {
         if ( IsConfirmed == 0 )
         {
            imgBtn_delete2_Enabled = RcdFound13 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         }
         else
         {
            imgBtn_delete2_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         }
      }

      protected void GetKey0D13( )
      {
         /* Using cursor T000D5 */
         pr_default.execute(3, new Object[] {A223TTBUS20_IdBien});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound13 = 1 ;
         }
         else
         {
            RcdFound13 = 0 ;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000D3 */
         pr_default.execute(1, new Object[] {A223TTBUS20_IdBien});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0D13( 2) ;
            RcdFound13 = 1 ;
            A223TTBUS20_IdBien = T000D3_A223TTBUS20_IdBien[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A223TTBUS20_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A223TTBUS20_IdBien), 8, 0)));
            A224TTBUS20_Descripcion = T000D3_A224TTBUS20_Descripcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A224TTBUS20_Descripcion", A224TTBUS20_Descripcion);
            A218TTBUS20_Mensaje = T000D3_A218TTBUS20_Mensaje[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A218TTBUS20_Mensaje", A218TTBUS20_Mensaje);
            A220TTBUS20_MotivoEnvio = T000D3_A220TTBUS20_MotivoEnvio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A220TTBUS20_MotivoEnvio", A220TTBUS20_MotivoEnvio);
            A221TTBUS20_Observaciones = T000D3_A221TTBUS20_Observaciones[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A221TTBUS20_Observaciones", A221TTBUS20_Observaciones);
            A219TTBUS20_Estacion = T000D3_A219TTBUS20_Estacion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A219TTBUS20_Estacion", A219TTBUS20_Estacion);
            A225TTBUS20_Usuario = T000D3_A225TTBUS20_Usuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A225TTBUS20_Usuario", A225TTBUS20_Usuario);
            A222TTBUS20_PlazoRecepcion = T000D3_A222TTBUS20_PlazoRecepcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A222TTBUS20_PlazoRecepcion", context.localUtil.Format(A222TTBUS20_PlazoRecepcion, "99/99/9999"));
            n222TTBUS20_PlazoRecepcion = T000D3_n222TTBUS20_PlazoRecepcion[0] ;
            Z223TTBUS20_IdBien = A223TTBUS20_IdBien ;
            sMode13 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load0D13( ) ;
            Gx_mode = sMode13 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound13 = 0 ;
            InitializeNonKey0D13( ) ;
            sMode13 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode13 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0D13( ) ;
         if ( RcdFound13 == 0 )
         {
            Gx_mode = "INS" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound13 = 0 ;
         /* Using cursor T000D6 */
         pr_default.execute(4, new Object[] {A223TTBUS20_IdBien});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T000D6_A223TTBUS20_IdBien[0] < A223TTBUS20_IdBien ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T000D6_A223TTBUS20_IdBien[0] > A223TTBUS20_IdBien ) ) )
            {
               A223TTBUS20_IdBien = T000D6_A223TTBUS20_IdBien[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A223TTBUS20_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A223TTBUS20_IdBien), 8, 0)));
               RcdFound13 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound13 = 0 ;
         /* Using cursor T000D7 */
         pr_default.execute(5, new Object[] {A223TTBUS20_IdBien});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T000D7_A223TTBUS20_IdBien[0] > A223TTBUS20_IdBien ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T000D7_A223TTBUS20_IdBien[0] < A223TTBUS20_IdBien ) ) )
            {
               A223TTBUS20_IdBien = T000D7_A223TTBUS20_IdBien[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A223TTBUS20_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A223TTBUS20_IdBien), 8, 0)));
               RcdFound13 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey0D13( ) ;
         if ( RcdFound13 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "TTBUS20_IDBIEN");
               AnyError = 1 ;
               GX_FocusControl = edtTTBUS20_IdBien_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( A223TTBUS20_IdBien != Z223TTBUS20_IdBien )
            {
               A223TTBUS20_IdBien = Z223TTBUS20_IdBien ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A223TTBUS20_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A223TTBUS20_IdBien), 8, 0)));
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "CandidateKeyNotFound", 1, "TTBUS20_IDBIEN");
               AnyError = 1 ;
               GX_FocusControl = edtTTBUS20_IdBien_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtTTBUS20_IdBien_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               Gx_mode = "UPD" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Update record */
               Update0D13( ) ;
               GX_FocusControl = edtTTBUS20_IdBien_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( A223TTBUS20_IdBien != Z223TTBUS20_IdBien )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               Insert0D13( ) ;
               GX_FocusControl = edtTTBUS20_IdBien_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "TTBUS20_IDBIEN");
                  AnyError = 1 ;
                  GX_FocusControl = edtTTBUS20_IdBien_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "INS" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  Insert0D13( ) ;
                  GX_FocusControl = edtTTBUS20_IdBien_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
         }
         AfterTrn( ) ;
      }

      protected void btn_delete( )
      {
         if ( A223TTBUS20_IdBien != Z223TTBUS20_IdBien )
         {
            A223TTBUS20_IdBien = Z223TTBUS20_IdBien ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A223TTBUS20_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A223TTBUS20_IdBien), 8, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt"), 1, "TTBUS20_IDBIEN");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS20_IdBien_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtTTBUS20_IdBien_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         getByPrimaryKey( ) ;
         CloseOpenCursors();
      }

      protected void btn_get( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         if ( RcdFound13 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound"), "PrimaryKeyNotFound", 1, "TTBUS20_IDBIEN");
            AnyError = 1 ;
         }
         GX_FocusControl = edtTTBUS20_Descripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0D13( ) ;
         if ( RcdFound13 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtTTBUS20_Descripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0D13( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound13 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtTTBUS20_Descripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_next( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_next( ) ;
         if ( RcdFound13 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtTTBUS20_Descripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0D13( ) ;
         if ( RcdFound13 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            while ( RcdFound13 != 0 )
            {
               ScanNext0D13( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtTTBUS20_Descripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0D13( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0D13( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000D8 */
            pr_default.execute(6, new Object[] {A223TTBUS20_IdBien});
            if ( (pr_default.getStatus(6) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TTBUS020"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            Gx_longc = false ;
            if ( (pr_default.getStatus(6) == 101) || ( StringUtil.StrCmp(Z224TTBUS20_Descripcion, T000D8_A224TTBUS20_Descripcion[0]) != 0 ) || ( StringUtil.StrCmp(Z218TTBUS20_Mensaje, T000D8_A218TTBUS20_Mensaje[0]) != 0 ) || ( StringUtil.StrCmp(Z220TTBUS20_MotivoEnvio, T000D8_A220TTBUS20_MotivoEnvio[0]) != 0 ) || ( StringUtil.StrCmp(Z221TTBUS20_Observaciones, T000D8_A221TTBUS20_Observaciones[0]) != 0 ) || ( StringUtil.StrCmp(Z219TTBUS20_Estacion, T000D8_A219TTBUS20_Estacion[0]) != 0 ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z225TTBUS20_Usuario, T000D8_A225TTBUS20_Usuario[0]) != 0 ) || ( Z222TTBUS20_PlazoRecepcion != T000D8_A222TTBUS20_PlazoRecepcion[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"TTBUS020"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0D13( )
      {
         BeforeValidate0D13( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0D13( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0D13( 0) ;
            CheckOptimisticConcurrency0D13( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0D13( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0D13( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000D9 */
                     pr_default.execute(7, new Object[] {A223TTBUS20_IdBien, A224TTBUS20_Descripcion, A218TTBUS20_Mensaje, A220TTBUS20_MotivoEnvio, A221TTBUS20_Observaciones, A219TTBUS20_Estacion, A225TTBUS20_Usuario, n222TTBUS20_PlazoRecepcion, A222TTBUS20_PlazoRecepcion});
                     pr_default.close(7);
                     if ( (pr_default.getStatus(7) == 1) )
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
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded"), 0, "");
                           ResetCaption0D0( ) ;
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
               Load0D13( ) ;
            }
            EndLevel0D13( ) ;
         }
         CloseExtendedTableCursors0D13( ) ;
      }

      protected void Update0D13( )
      {
         BeforeValidate0D13( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0D13( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0D13( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0D13( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0D13( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000D10 */
                     pr_default.execute(8, new Object[] {A224TTBUS20_Descripcion, A218TTBUS20_Mensaje, A220TTBUS20_MotivoEnvio, A221TTBUS20_Observaciones, A219TTBUS20_Estacion, A225TTBUS20_Usuario, n222TTBUS20_PlazoRecepcion, A222TTBUS20_PlazoRecepcion, A223TTBUS20_IdBien});
                     pr_default.close(8);
                     if ( (pr_default.getStatus(8) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TTBUS020"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0D13( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated"), 0, "");
                           ResetCaption0D0( ) ;
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
            EndLevel0D13( ) ;
         }
         CloseExtendedTableCursors0D13( ) ;
      }

      protected void DeferredUpdate0D13( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0D13( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0D13( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0D13( ) ;
            AfterConfirm0D13( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0D13( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000D11 */
                  pr_default.execute(9, new Object[] {A223TTBUS20_IdBien});
                  pr_default.close(9);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound13 == 0 )
                        {
                           InitAll0D13( ) ;
                           Gx_mode = "INS" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        }
                        else
                        {
                           getByPrimaryKey( ) ;
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        }
                        GX_msglist.addItem(context.GetMessage( "GXM_sucdeleted"), 0, "");
                        ResetCaption0D0( ) ;
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
         sMode13 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0D13( ) ;
         Gx_mode = sMode13 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0D13( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0D13( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(6);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0D13( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(5);
            pr_default.close(4);
            context.CommitDataStores("TTBUS020");
            if ( AnyError == 0 )
            {
               ConfirmValues0D0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(5);
            pr_default.close(4);
            context.RollbackDataStores("TTBUS020");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart0D13( )
      {
         /* Using cursor T000D12 */
         pr_default.execute(10);
         RcdFound13 = 0 ;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound13 = 1 ;
            A223TTBUS20_IdBien = T000D12_A223TTBUS20_IdBien[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A223TTBUS20_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A223TTBUS20_IdBien), 8, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0D13( )
      {
         pr_default.readNext(10);
         RcdFound13 = 0 ;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound13 = 1 ;
            A223TTBUS20_IdBien = T000D12_A223TTBUS20_IdBien[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A223TTBUS20_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A223TTBUS20_IdBien), 8, 0)));
         }
      }

      protected void ScanEnd0D13( )
      {
      }

      protected void AfterConfirm0D13( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0D13( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0D13( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0D13( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0D13( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0D13( )
      {
         /* Before Validate Rules */
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0D0( )
      {
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
         context.AddJavascriptSource("calendar.js", "?42940");
         context.AddJavascriptSource("calendar-setup.js", "?42940");
         context.AddJavascriptSource("calendar-es.js", "?42940");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("ttbus020.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z223TTBUS20_IdBien", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z223TTBUS20_IdBien), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z224TTBUS20_Descripcion", StringUtil.RTrim( Z224TTBUS20_Descripcion));
         GxWebStd.gx_hidden_field( context, "Z218TTBUS20_Mensaje", StringUtil.RTrim( Z218TTBUS20_Mensaje));
         GxWebStd.gx_hidden_field( context, "Z220TTBUS20_MotivoEnvio", StringUtil.RTrim( Z220TTBUS20_MotivoEnvio));
         GxWebStd.gx_hidden_field( context, "Z221TTBUS20_Observaciones", StringUtil.RTrim( Z221TTBUS20_Observaciones));
         GxWebStd.gx_hidden_field( context, "Z219TTBUS20_Estacion", StringUtil.RTrim( Z219TTBUS20_Estacion));
         GxWebStd.gx_hidden_field( context, "Z225TTBUS20_Usuario", StringUtil.RTrim( Z225TTBUS20_Usuario));
         GxWebStd.gx_hidden_field( context, "Z222TTBUS20_PlazoRecepcion", context.localUtil.DToC( Z222TTBUS20_PlazoRecepcion, 0, "/"));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
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
         return "TTBUS020" ;
      }

      public override String GetPgmdesc( )
      {
         return "Mensajes de Administrador de Cambio de Posiciones" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("ttbus020.aspx")  ;
      }

      protected void InitializeNonKey0D13( )
      {
         A224TTBUS20_Descripcion = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A224TTBUS20_Descripcion", A224TTBUS20_Descripcion);
         A218TTBUS20_Mensaje = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A218TTBUS20_Mensaje", A218TTBUS20_Mensaje);
         A220TTBUS20_MotivoEnvio = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A220TTBUS20_MotivoEnvio", A220TTBUS20_MotivoEnvio);
         A221TTBUS20_Observaciones = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A221TTBUS20_Observaciones", A221TTBUS20_Observaciones);
         A219TTBUS20_Estacion = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A219TTBUS20_Estacion", A219TTBUS20_Estacion);
         A225TTBUS20_Usuario = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A225TTBUS20_Usuario", A225TTBUS20_Usuario);
         A222TTBUS20_PlazoRecepcion = DateTime.MinValue ;
         n222TTBUS20_PlazoRecepcion = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A222TTBUS20_PlazoRecepcion", context.localUtil.Format(A222TTBUS20_PlazoRecepcion, "99/99/9999"));
         n222TTBUS20_PlazoRecepcion = ((DateTime.MinValue==A222TTBUS20_PlazoRecepcion) ? true : false) ;
      }

      protected void InitAll0D13( )
      {
         A223TTBUS20_IdBien = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A223TTBUS20_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A223TTBUS20_IdBien), 8, 0)));
         InitializeNonKey0D13( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?84120");
         AddThemeStyleSheetFile("", "Modern.css", "?2051812");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?11472499");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("ttbus020.js", "?11472499");
         /* End function include_jscripts */
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
         lblTextblockttbus20_idbien_Internalname = "TEXTBLOCKTTBUS20_IDBIEN" ;
         edtTTBUS20_IdBien_Internalname = "TTBUS20_IDBIEN" ;
         lblTextblockttbus20_descripcion_Internalname = "TEXTBLOCKTTBUS20_DESCRIPCION" ;
         edtTTBUS20_Descripcion_Internalname = "TTBUS20_DESCRIPCION" ;
         lblTextblockttbus20_mensaje_Internalname = "TEXTBLOCKTTBUS20_MENSAJE" ;
         edtTTBUS20_Mensaje_Internalname = "TTBUS20_MENSAJE" ;
         lblTextblockttbus20_motivoenvio_Internalname = "TEXTBLOCKTTBUS20_MOTIVOENVIO" ;
         edtTTBUS20_MotivoEnvio_Internalname = "TTBUS20_MOTIVOENVIO" ;
         lblTextblockttbus20_observaciones_Internalname = "TEXTBLOCKTTBUS20_OBSERVACIONES" ;
         edtTTBUS20_Observaciones_Internalname = "TTBUS20_OBSERVACIONES" ;
         lblTextblockttbus20_estacion_Internalname = "TEXTBLOCKTTBUS20_ESTACION" ;
         edtTTBUS20_Estacion_Internalname = "TTBUS20_ESTACION" ;
         lblTextblockttbus20_usuario_Internalname = "TEXTBLOCKTTBUS20_USUARIO" ;
         edtTTBUS20_Usuario_Internalname = "TTBUS20_USUARIO" ;
         lblTextblockttbus20_plazorecepcion_Internalname = "TEXTBLOCKTTBUS20_PLAZORECEPCION" ;
         edtTTBUS20_PlazoRecepcion_Internalname = "TTBUS20_PLAZORECEPCION" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Mensajes de Administrador de Cambio de Posiciones" ;
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
         edtTTBUS20_PlazoRecepcion_Jsonclick = "" ;
         edtTTBUS20_PlazoRecepcion_Enabled = 1 ;
         edtTTBUS20_Usuario_Jsonclick = "" ;
         edtTTBUS20_Usuario_Enabled = 1 ;
         edtTTBUS20_Estacion_Jsonclick = "" ;
         edtTTBUS20_Estacion_Enabled = 1 ;
         edtTTBUS20_Observaciones_Enabled = 1 ;
         edtTTBUS20_MotivoEnvio_Jsonclick = "" ;
         edtTTBUS20_MotivoEnvio_Enabled = 1 ;
         edtTTBUS20_Mensaje_Jsonclick = "" ;
         edtTTBUS20_Mensaje_Enabled = 1 ;
         edtTTBUS20_Descripcion_Jsonclick = "" ;
         edtTTBUS20_Descripcion_Enabled = 1 ;
         edtTTBUS20_IdBien_Jsonclick = "" ;
         edtTTBUS20_IdBien_Enabled = 1 ;
         bttBtn_delete_Visible = 1 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_enter_Visible = 1 ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         GX_FocusControl = edtTTBUS20_Descripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Ttbus20_idbien( int GX_Parm1 ,
                                        String GX_Parm2 ,
                                        String GX_Parm3 ,
                                        String GX_Parm4 ,
                                        String GX_Parm5 ,
                                        String GX_Parm6 ,
                                        String GX_Parm7 ,
                                        DateTime GX_Parm8 )
      {
         A223TTBUS20_IdBien = GX_Parm1 ;
         A224TTBUS20_Descripcion = GX_Parm2 ;
         A218TTBUS20_Mensaje = GX_Parm3 ;
         A220TTBUS20_MotivoEnvio = GX_Parm4 ;
         A221TTBUS20_Observaciones = GX_Parm5 ;
         A219TTBUS20_Estacion = GX_Parm6 ;
         A225TTBUS20_Usuario = GX_Parm7 ;
         A222TTBUS20_PlazoRecepcion = GX_Parm8 ;
         n222TTBUS20_PlazoRecepcion = false ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A224TTBUS20_Descripcion)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A218TTBUS20_Mensaje)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A220TTBUS20_MotivoEnvio)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A221TTBUS20_Observaciones)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A219TTBUS20_Estacion)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A225TTBUS20_Usuario)));
         isValidOutput.Add((Object)(context.localUtil.Format(A222TTBUS20_PlazoRecepcion, "99/99/9999")));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z223TTBUS20_IdBien), 8, 0, ",", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z224TTBUS20_Descripcion)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z218TTBUS20_Mensaje)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z220TTBUS20_MotivoEnvio)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z221TTBUS20_Observaciones)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z219TTBUS20_Estacion)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z225TTBUS20_Usuario)));
         isValidOutput.Add((Object)(context.localUtil.DToC( Z222TTBUS20_PlazoRecepcion, 0, "/")));
         isValidOutput.Add((Object)(imgBtn_enter2_Enabled));
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
         pr_default.close(10);
         pr_default.close(5);
         pr_default.close(4);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
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
         lblTextblockttbus20_idbien_Jsonclick = "" ;
         lblTextblockttbus20_descripcion_Jsonclick = "" ;
         A224TTBUS20_Descripcion = "" ;
         lblTextblockttbus20_mensaje_Jsonclick = "" ;
         A218TTBUS20_Mensaje = "" ;
         lblTextblockttbus20_motivoenvio_Jsonclick = "" ;
         A220TTBUS20_MotivoEnvio = "" ;
         lblTextblockttbus20_observaciones_Jsonclick = "" ;
         A221TTBUS20_Observaciones = "" ;
         lblTextblockttbus20_estacion_Jsonclick = "" ;
         A219TTBUS20_Estacion = "" ;
         lblTextblockttbus20_usuario_Jsonclick = "" ;
         A225TTBUS20_Usuario = "" ;
         lblTextblockttbus20_plazorecepcion_Jsonclick = "" ;
         A222TTBUS20_PlazoRecepcion = DateTime.MinValue ;
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
         Z224TTBUS20_Descripcion = "" ;
         Z218TTBUS20_Mensaje = "" ;
         Z220TTBUS20_MotivoEnvio = "" ;
         Z221TTBUS20_Observaciones = "" ;
         Z219TTBUS20_Estacion = "" ;
         Z225TTBUS20_Usuario = "" ;
         Z222TTBUS20_PlazoRecepcion = DateTime.MinValue ;
         Gx_mode = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         T000D4_A223TTBUS20_IdBien = new int[1] ;
         T000D4_A224TTBUS20_Descripcion = new String[] {""} ;
         T000D4_A218TTBUS20_Mensaje = new String[] {""} ;
         T000D4_A220TTBUS20_MotivoEnvio = new String[] {""} ;
         T000D4_A221TTBUS20_Observaciones = new String[] {""} ;
         T000D4_A219TTBUS20_Estacion = new String[] {""} ;
         T000D4_A225TTBUS20_Usuario = new String[] {""} ;
         T000D4_A222TTBUS20_PlazoRecepcion = new DateTime[] {DateTime.MinValue} ;
         T000D4_n222TTBUS20_PlazoRecepcion = new bool[] {false} ;
         T000D5_A223TTBUS20_IdBien = new int[1] ;
         T000D3_A223TTBUS20_IdBien = new int[1] ;
         T000D3_A224TTBUS20_Descripcion = new String[] {""} ;
         T000D3_A218TTBUS20_Mensaje = new String[] {""} ;
         T000D3_A220TTBUS20_MotivoEnvio = new String[] {""} ;
         T000D3_A221TTBUS20_Observaciones = new String[] {""} ;
         T000D3_A219TTBUS20_Estacion = new String[] {""} ;
         T000D3_A225TTBUS20_Usuario = new String[] {""} ;
         T000D3_A222TTBUS20_PlazoRecepcion = new DateTime[] {DateTime.MinValue} ;
         T000D3_n222TTBUS20_PlazoRecepcion = new bool[] {false} ;
         sMode13 = "" ;
         T000D6_A223TTBUS20_IdBien = new int[1] ;
         T000D7_A223TTBUS20_IdBien = new int[1] ;
         T000D8_A223TTBUS20_IdBien = new int[1] ;
         T000D8_A224TTBUS20_Descripcion = new String[] {""} ;
         T000D8_A218TTBUS20_Mensaje = new String[] {""} ;
         T000D8_A220TTBUS20_MotivoEnvio = new String[] {""} ;
         T000D8_A221TTBUS20_Observaciones = new String[] {""} ;
         T000D8_A219TTBUS20_Estacion = new String[] {""} ;
         T000D8_A225TTBUS20_Usuario = new String[] {""} ;
         T000D8_A222TTBUS20_PlazoRecepcion = new DateTime[] {DateTime.MinValue} ;
         T000D8_n222TTBUS20_PlazoRecepcion = new bool[] {false} ;
         T000D12_A223TTBUS20_IdBien = new int[1] ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ttbus020__default(),
            new Object[][] {
                new Object[] {
               T000D2_A223TTBUS20_IdBien, T000D2_A224TTBUS20_Descripcion, T000D2_A218TTBUS20_Mensaje, T000D2_A220TTBUS20_MotivoEnvio, T000D2_A221TTBUS20_Observaciones, T000D2_A219TTBUS20_Estacion, T000D2_A225TTBUS20_Usuario, T000D2_A222TTBUS20_PlazoRecepcion, T000D2_n222TTBUS20_PlazoRecepcion
               }
               , new Object[] {
               T000D3_A223TTBUS20_IdBien, T000D3_A224TTBUS20_Descripcion, T000D3_A218TTBUS20_Mensaje, T000D3_A220TTBUS20_MotivoEnvio, T000D3_A221TTBUS20_Observaciones, T000D3_A219TTBUS20_Estacion, T000D3_A225TTBUS20_Usuario, T000D3_A222TTBUS20_PlazoRecepcion, T000D3_n222TTBUS20_PlazoRecepcion
               }
               , new Object[] {
               T000D4_A223TTBUS20_IdBien, T000D4_A224TTBUS20_Descripcion, T000D4_A218TTBUS20_Mensaje, T000D4_A220TTBUS20_MotivoEnvio, T000D4_A221TTBUS20_Observaciones, T000D4_A219TTBUS20_Estacion, T000D4_A225TTBUS20_Usuario, T000D4_A222TTBUS20_PlazoRecepcion, T000D4_n222TTBUS20_PlazoRecepcion
               }
               , new Object[] {
               T000D5_A223TTBUS20_IdBien
               }
               , new Object[] {
               T000D6_A223TTBUS20_IdBien
               }
               , new Object[] {
               T000D7_A223TTBUS20_IdBien
               }
               , new Object[] {
               T000D8_A223TTBUS20_IdBien, T000D8_A224TTBUS20_Descripcion, T000D8_A218TTBUS20_Mensaje, T000D8_A220TTBUS20_MotivoEnvio, T000D8_A221TTBUS20_Observaciones, T000D8_A219TTBUS20_Estacion, T000D8_A225TTBUS20_Usuario, T000D8_A222TTBUS20_PlazoRecepcion, T000D8_n222TTBUS20_PlazoRecepcion
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000D12_A223TTBUS20_IdBien
               }
            }
         );
      }

      private short RcdFound13 ;
      private short GxWebError ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int A223TTBUS20_IdBien ;
      private int edtTTBUS20_IdBien_Enabled ;
      private int edtTTBUS20_Descripcion_Enabled ;
      private int edtTTBUS20_Mensaje_Enabled ;
      private int edtTTBUS20_MotivoEnvio_Enabled ;
      private int edtTTBUS20_Observaciones_Enabled ;
      private int edtTTBUS20_Estacion_Enabled ;
      private int edtTTBUS20_Usuario_Enabled ;
      private int edtTTBUS20_PlazoRecepcion_Enabled ;
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
      private int Z223TTBUS20_IdBien ;
      private int idxLst ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtTTBUS20_IdBien_Internalname ;
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
      private String lblTextblockttbus20_idbien_Internalname ;
      private String lblTextblockttbus20_idbien_Jsonclick ;
      private String edtTTBUS20_IdBien_Jsonclick ;
      private String lblTextblockttbus20_descripcion_Internalname ;
      private String lblTextblockttbus20_descripcion_Jsonclick ;
      private String edtTTBUS20_Descripcion_Internalname ;
      private String A224TTBUS20_Descripcion ;
      private String edtTTBUS20_Descripcion_Jsonclick ;
      private String lblTextblockttbus20_mensaje_Internalname ;
      private String lblTextblockttbus20_mensaje_Jsonclick ;
      private String edtTTBUS20_Mensaje_Internalname ;
      private String edtTTBUS20_Mensaje_Jsonclick ;
      private String lblTextblockttbus20_motivoenvio_Internalname ;
      private String lblTextblockttbus20_motivoenvio_Jsonclick ;
      private String edtTTBUS20_MotivoEnvio_Internalname ;
      private String edtTTBUS20_MotivoEnvio_Jsonclick ;
      private String lblTextblockttbus20_observaciones_Internalname ;
      private String lblTextblockttbus20_observaciones_Jsonclick ;
      private String edtTTBUS20_Observaciones_Internalname ;
      private String lblTextblockttbus20_estacion_Internalname ;
      private String lblTextblockttbus20_estacion_Jsonclick ;
      private String edtTTBUS20_Estacion_Internalname ;
      private String A219TTBUS20_Estacion ;
      private String edtTTBUS20_Estacion_Jsonclick ;
      private String lblTextblockttbus20_usuario_Internalname ;
      private String lblTextblockttbus20_usuario_Jsonclick ;
      private String edtTTBUS20_Usuario_Internalname ;
      private String A225TTBUS20_Usuario ;
      private String edtTTBUS20_Usuario_Jsonclick ;
      private String lblTextblockttbus20_plazorecepcion_Internalname ;
      private String lblTextblockttbus20_plazorecepcion_Jsonclick ;
      private String edtTTBUS20_PlazoRecepcion_Internalname ;
      private String edtTTBUS20_PlazoRecepcion_Jsonclick ;
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
      private String Z224TTBUS20_Descripcion ;
      private String Z219TTBUS20_Estacion ;
      private String Z225TTBUS20_Usuario ;
      private String Gx_mode ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sMode13 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private DateTime A222TTBUS20_PlazoRecepcion ;
      private DateTime Z222TTBUS20_PlazoRecepcion ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool n222TTBUS20_PlazoRecepcion ;
      private bool Gx_longc ;
      private String A218TTBUS20_Mensaje ;
      private String A220TTBUS20_MotivoEnvio ;
      private String A221TTBUS20_Observaciones ;
      private String Z218TTBUS20_Mensaje ;
      private String Z220TTBUS20_MotivoEnvio ;
      private String Z221TTBUS20_Observaciones ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] T000D4_A223TTBUS20_IdBien ;
      private String[] T000D4_A224TTBUS20_Descripcion ;
      private String[] T000D4_A218TTBUS20_Mensaje ;
      private String[] T000D4_A220TTBUS20_MotivoEnvio ;
      private String[] T000D4_A221TTBUS20_Observaciones ;
      private String[] T000D4_A219TTBUS20_Estacion ;
      private String[] T000D4_A225TTBUS20_Usuario ;
      private DateTime[] T000D4_A222TTBUS20_PlazoRecepcion ;
      private bool[] T000D4_n222TTBUS20_PlazoRecepcion ;
      private int[] T000D5_A223TTBUS20_IdBien ;
      private int[] T000D3_A223TTBUS20_IdBien ;
      private String[] T000D3_A224TTBUS20_Descripcion ;
      private String[] T000D3_A218TTBUS20_Mensaje ;
      private String[] T000D3_A220TTBUS20_MotivoEnvio ;
      private String[] T000D3_A221TTBUS20_Observaciones ;
      private String[] T000D3_A219TTBUS20_Estacion ;
      private String[] T000D3_A225TTBUS20_Usuario ;
      private DateTime[] T000D3_A222TTBUS20_PlazoRecepcion ;
      private bool[] T000D3_n222TTBUS20_PlazoRecepcion ;
      private int[] T000D6_A223TTBUS20_IdBien ;
      private int[] T000D7_A223TTBUS20_IdBien ;
      private int[] T000D8_A223TTBUS20_IdBien ;
      private String[] T000D8_A224TTBUS20_Descripcion ;
      private String[] T000D8_A218TTBUS20_Mensaje ;
      private String[] T000D8_A220TTBUS20_MotivoEnvio ;
      private String[] T000D8_A221TTBUS20_Observaciones ;
      private String[] T000D8_A219TTBUS20_Estacion ;
      private String[] T000D8_A225TTBUS20_Usuario ;
      private DateTime[] T000D8_A222TTBUS20_PlazoRecepcion ;
      private bool[] T000D8_n222TTBUS20_PlazoRecepcion ;
      private int[] T000D12_A223TTBUS20_IdBien ;
      private int[] T000D2_A223TTBUS20_IdBien ;
      private String[] T000D2_A224TTBUS20_Descripcion ;
      private String[] T000D2_A218TTBUS20_Mensaje ;
      private String[] T000D2_A220TTBUS20_MotivoEnvio ;
      private String[] T000D2_A221TTBUS20_Observaciones ;
      private String[] T000D2_A219TTBUS20_Estacion ;
      private String[] T000D2_A225TTBUS20_Usuario ;
      private DateTime[] T000D2_A222TTBUS20_PlazoRecepcion ;
      private bool[] T000D2_n222TTBUS20_PlazoRecepcion ;
      private GXWebForm Form ;
   }

   public class ttbus020__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[7])
         ,new UpdateCursor(def[8])
         ,new UpdateCursor(def[9])
         ,new ForEachCursor(def[10])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000D2 ;
          prmT000D2 = new Object[] {
          new Object[] {"@TTBUS20_IdBien",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000D4 ;
          prmT000D4 = new Object[] {
          new Object[] {"@TTBUS20_IdBien",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000D5 ;
          prmT000D5 = new Object[] {
          new Object[] {"@TTBUS20_IdBien",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000D3 ;
          prmT000D3 = new Object[] {
          new Object[] {"@TTBUS20_IdBien",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000D6 ;
          prmT000D6 = new Object[] {
          new Object[] {"@TTBUS20_IdBien",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000D7 ;
          prmT000D7 = new Object[] {
          new Object[] {"@TTBUS20_IdBien",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000D8 ;
          prmT000D8 = new Object[] {
          new Object[] {"@TTBUS20_IdBien",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000D9 ;
          prmT000D9 = new Object[] {
          new Object[] {"@TTBUS20_IdBien",SqlDbType.Int,8,0} ,
          new Object[] {"@TTBUS20_Descripcion",SqlDbType.Char,50,0} ,
          new Object[] {"@TTBUS20_Mensaje",SqlDbType.VarChar,100,0} ,
          new Object[] {"@TTBUS20_MotivoEnvio",SqlDbType.VarChar,100,0} ,
          new Object[] {"@TTBUS20_Observaciones",SqlDbType.VarChar,500,0} ,
          new Object[] {"@TTBUS20_Estacion",SqlDbType.Char,20,0} ,
          new Object[] {"@TTBUS20_Usuario",SqlDbType.Char,16,0} ,
          new Object[] {"@TTBUS20_PlazoRecepcion",SqlDbType.DateTime,8,0}
          } ;
          Object[] prmT000D10 ;
          prmT000D10 = new Object[] {
          new Object[] {"@TTBUS20_Descripcion",SqlDbType.Char,50,0} ,
          new Object[] {"@TTBUS20_Mensaje",SqlDbType.VarChar,100,0} ,
          new Object[] {"@TTBUS20_MotivoEnvio",SqlDbType.VarChar,100,0} ,
          new Object[] {"@TTBUS20_Observaciones",SqlDbType.VarChar,500,0} ,
          new Object[] {"@TTBUS20_Estacion",SqlDbType.Char,20,0} ,
          new Object[] {"@TTBUS20_Usuario",SqlDbType.Char,16,0} ,
          new Object[] {"@TTBUS20_PlazoRecepcion",SqlDbType.DateTime,8,0} ,
          new Object[] {"@TTBUS20_IdBien",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000D11 ;
          prmT000D11 = new Object[] {
          new Object[] {"@TTBUS20_IdBien",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000D12 ;
          prmT000D12 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T000D2", "SELECT [TTBUS20_IdBien], [TTBUS20_Descripcion], [TTBUS20_Mensaje], [TTBUS20_MotivoEnvio], [TTBUS20_Observaciones], [TTBUS20_Estacion], [TTBUS20_Usuario], [TTBUS20_PlazoRecepcion] FROM [TTBUS020] WITH (UPDLOCK) WHERE [TTBUS20_IdBien] = @TTBUS20_IdBien ",true, GxErrorMask.GX_NOMASK, false, this,prmT000D2,1,0,true,false )
             ,new CursorDef("T000D3", "SELECT [TTBUS20_IdBien], [TTBUS20_Descripcion], [TTBUS20_Mensaje], [TTBUS20_MotivoEnvio], [TTBUS20_Observaciones], [TTBUS20_Estacion], [TTBUS20_Usuario], [TTBUS20_PlazoRecepcion] FROM [TTBUS020] WITH (NOLOCK) WHERE [TTBUS20_IdBien] = @TTBUS20_IdBien ",true, GxErrorMask.GX_NOMASK, false, this,prmT000D3,1,0,true,false )
             ,new CursorDef("T000D4", "SELECT TM1.[TTBUS20_IdBien], TM1.[TTBUS20_Descripcion], TM1.[TTBUS20_Mensaje], TM1.[TTBUS20_MotivoEnvio], TM1.[TTBUS20_Observaciones], TM1.[TTBUS20_Estacion], TM1.[TTBUS20_Usuario], TM1.[TTBUS20_PlazoRecepcion] FROM [TTBUS020] TM1 WITH (NOLOCK) WHERE TM1.[TTBUS20_IdBien] = @TTBUS20_IdBien ORDER BY TM1.[TTBUS20_IdBien]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000D4,100,0,true,false )
             ,new CursorDef("T000D5", "SELECT [TTBUS20_IdBien] FROM [TTBUS020] WITH (NOLOCK) WHERE [TTBUS20_IdBien] = @TTBUS20_IdBien  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000D5,1,0,true,false )
             ,new CursorDef("T000D6", "SELECT TOP 1 [TTBUS20_IdBien] FROM [TTBUS020] WITH (NOLOCK) WHERE ( [TTBUS20_IdBien] > @TTBUS20_IdBien) ORDER BY [TTBUS20_IdBien]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000D6,1,0,true,true )
             ,new CursorDef("T000D7", "SELECT TOP 1 [TTBUS20_IdBien] FROM [TTBUS020] WITH (NOLOCK) WHERE ( [TTBUS20_IdBien] < @TTBUS20_IdBien) ORDER BY [TTBUS20_IdBien] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000D7,1,0,true,true )
             ,new CursorDef("T000D8", "SELECT [TTBUS20_IdBien], [TTBUS20_Descripcion], [TTBUS20_Mensaje], [TTBUS20_MotivoEnvio], [TTBUS20_Observaciones], [TTBUS20_Estacion], [TTBUS20_Usuario], [TTBUS20_PlazoRecepcion] FROM [TTBUS020] WITH (UPDLOCK) WHERE [TTBUS20_IdBien] = @TTBUS20_IdBien ",true, GxErrorMask.GX_NOMASK, false, this,prmT000D8,1,0,true,false )
             ,new CursorDef("T000D9", "INSERT INTO [TTBUS020] ([TTBUS20_IdBien], [TTBUS20_Descripcion], [TTBUS20_Mensaje], [TTBUS20_MotivoEnvio], [TTBUS20_Observaciones], [TTBUS20_Estacion], [TTBUS20_Usuario], [TTBUS20_PlazoRecepcion]) VALUES (@TTBUS20_IdBien, @TTBUS20_Descripcion, @TTBUS20_Mensaje, @TTBUS20_MotivoEnvio, @TTBUS20_Observaciones, @TTBUS20_Estacion, @TTBUS20_Usuario, @TTBUS20_PlazoRecepcion)", GxErrorMask.GX_NOMASK,prmT000D9)
             ,new CursorDef("T000D10", "UPDATE [TTBUS020] SET [TTBUS20_Descripcion]=@TTBUS20_Descripcion, [TTBUS20_Mensaje]=@TTBUS20_Mensaje, [TTBUS20_MotivoEnvio]=@TTBUS20_MotivoEnvio, [TTBUS20_Observaciones]=@TTBUS20_Observaciones, [TTBUS20_Estacion]=@TTBUS20_Estacion, [TTBUS20_Usuario]=@TTBUS20_Usuario, [TTBUS20_PlazoRecepcion]=@TTBUS20_PlazoRecepcion  WHERE [TTBUS20_IdBien] = @TTBUS20_IdBien", GxErrorMask.GX_NOMASK,prmT000D10)
             ,new CursorDef("T000D11", "DELETE FROM [TTBUS020]  WHERE [TTBUS20_IdBien] = @TTBUS20_IdBien", GxErrorMask.GX_NOMASK,prmT000D11)
             ,new CursorDef("T000D12", "SELECT [TTBUS20_IdBien] FROM [TTBUS020] WITH (NOLOCK) ORDER BY [TTBUS20_IdBien]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000D12,100,0,true,false )
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 20) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 16) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(8) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(8);
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 20) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 16) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(8) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(8);
                break;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 20) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 16) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(8) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(8);
                break;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 5 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 6 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 20) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 16) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(8) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(8);
                break;
             case 10 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
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
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 7 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 8 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(8, (DateTime)parms[8]);
                }
                break;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 7 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(7, (DateTime)parms[7]);
                }
                stmt.SetParameter(8, (int)parms[8]);
                break;
             case 9 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
       }
    }

 }

}
