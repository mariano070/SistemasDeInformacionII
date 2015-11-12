/*
               File: TTBUS000_b
        Description: Baja de un Bien de Uso
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 3/17/2014 13:22:14.90
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
   public class ttbus000_b : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         if ( ! entryPointCalled )
         {
            AV8TTBUS_Id = (int)(NumberUtil.Val( gxfirstwebparm, ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8TTBUS_Id), 8, 0)));
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               Gx_mode = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               AV7SISTEMA = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7SISTEMA", AV7SISTEMA);
               AV9USUARIO = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9USUARIO", AV9USUARIO);
            }
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Baja de un Bien de Uso", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtTTBUS_FechaBaja_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Modern");
      }

      public ttbus000_b( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ttbus000_b( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref int aP0_TTBUS_Id ,
                           ref String aP1_Gx_mode ,
                           ref String aP2_SISTEMA ,
                           ref String aP3_USUARIO )
      {
         this.AV8TTBUS_Id = aP0_TTBUS_Id;
         this.Gx_mode = aP1_Gx_mode;
         this.AV7SISTEMA = aP2_SISTEMA;
         this.AV9USUARIO = aP3_USUARIO;
         executePrivate();
         aP0_TTBUS_Id=this.AV8TTBUS_Id;
         aP1_Gx_mode=this.Gx_mode;
         aP2_SISTEMA=this.AV7SISTEMA;
         aP3_USUARIO=this.AV9USUARIO;
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("promptmasterpage", "GeneXus.Programs.promptmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
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
            context.WriteHtmlText( "<p>") ;
            wb_table1_3_031( true) ;
         }
         return  ;
      }

      protected void wb_table1_3_031e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</p>") ;
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_3_031( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(188), 10, 0)) + "px" + ";" ;
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(348), 10, 0)) + "px" + ";" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;width:376px;height:145px;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Baja de un Bien de Uso"+"</legend>") ;
            wb_table2_7_031( true) ;
         }
         return  ;
      }

      protected void wb_table2_7_031e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_3_031e( true) ;
         }
         else
         {
            wb_table1_3_031e( false) ;
         }
      }

      protected void wb_table2_7_031( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
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
            wb_table3_13_031( true) ;
         }
         return  ;
      }

      protected void wb_table3_13_031e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_enter_Internalname, "Confirmar", "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "rounded", 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "HLP_TTBUS000_b.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "HLP_TTBUS000_b.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_delete_Internalname, "Eliminar", "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "rounded", 5, bttBtn_delete_Jsonclick, "EDELETE.", TempTags, "", "", "HLP_TTBUS000_b.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_7_031e( true) ;
         }
         else
         {
            wb_table2_7_031e( false) ;
         }
      }

      protected void wb_table3_13_031( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\"  style=\"height:22px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus_fechabaja_Internalname, 1, 1, 0, "Fecha de Baja:", "", "", "", 0, lblTextblockttbus_fechabaja_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS000_b.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtTTBUS_FechaBaja_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS_FechaBaja_Internalname, context.localUtil.Format(A16TTBUS_FechaBaja, "99/99/9999"), "", 10, "chr", 1, "row", 10, 1, edtTTBUS_FechaBaja_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A16TTBUS_FechaBaja, "99/99/9999"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(18);\"", 0, edtTTBUS_FechaBaja_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TTBUS000_b.htm");
            GxWebStd.gx_bitmap( context, edtTTBUS_FechaBaja_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(edtTTBUS_FechaBaja_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_TTBUS000_b.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\"  style=\"height:21px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus_motivobaja_Internalname, 1, 1, 0, "Motivo de Baja:", "", "", "", 0, lblTextblockttbus_motivobaja_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS000_b.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS_MotivoBaja_Internalname, StringUtil.RTrim( A43TTBUS_MotivoBaja), "", 50, "chr", 1, "row", 50, 1, edtTTBUS_MotivoBaja_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A43TTBUS_MotivoBaja, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(23);\"", 0, edtTTBUS_MotivoBaja_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TTBUS000_b.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus_motivobaja2_Internalname, 1, 1, 0, "Usuario de Baja:", "", "", "", 0, lblTextblockttbus_motivobaja2_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS000_b.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS_UsuarioBaja_Internalname, StringUtil.RTrim( A195TTBUS_UsuarioBaja), "", 15, "chr", 1, "row", 15, edtTTBUS_UsuarioBaja_Visible, edtTTBUS_UsuarioBaja_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A195TTBUS_UsuarioBaja, "XXXXXXXXXXXXXXX")), "", 0, edtTTBUS_UsuarioBaja_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TTBUS000_b.htm");
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavTtbus_usuariobaja_Internalname, StringUtil.RTrim( AV11TTBUS_UsuarioBaja), "", 15, "chr", 1, "row", 15, edtavTtbus_usuariobaja_Visible, edtavTtbus_usuariobaja_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV11TTBUS_UsuarioBaja, "XXXXXXXXXXXXXXX")), "", 0, edtavTtbus_usuariobaja_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TTBUS000_b.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus_motivobaja3_Internalname, 1, 1, 0, "Estación de Trabajo:", "", "", "", 0, lblTextblockttbus_motivobaja3_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS000_b.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS_MaquinaBaja_Internalname, StringUtil.RTrim( A196TTBUS_MaquinaBaja), "", 20, "chr", 1, "row", 20, edtTTBUS_MaquinaBaja_Visible, edtTTBUS_MaquinaBaja_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A196TTBUS_MaquinaBaja, "XXXXXXXXXXXXXXXXXXXX")), "", 0, edtTTBUS_MaquinaBaja_Jsonclick, "", 0, 1, 1, true, "left", "HLP_TTBUS000_b.htm");
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavTtbus_maquinabaja_Internalname, StringUtil.RTrim( AV10TTBUS_MaquinaBaja), "", 20, "chr", 1, "row", 20, edtavTtbus_maquinabaja_Visible, edtavTtbus_maquinabaja_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV10TTBUS_MaquinaBaja, "XXXXXXXXXXXXXXXXXXXX")), "", 0, edtavTtbus_maquinabaja_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TTBUS000_b.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_13_031e( true) ;
         }
         else
         {
            wb_table3_13_031e( false) ;
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
         /* Execute user event: E11032 */
         E11032 ();
         context.wbGlbDoneStart = 1 ;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( context.localUtil.VCDate( cgiGet( edtTTBUS_FechaBaja_Internalname), 4) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha de Baja"}), 1, "TTBUS_FECHABAJA");
                  AnyError = 1 ;
                  GX_FocusControl = edtTTBUS_FechaBaja_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A16TTBUS_FechaBaja = DateTime.MinValue ;
                  n16TTBUS_FechaBaja = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16TTBUS_FechaBaja", context.localUtil.Format(A16TTBUS_FechaBaja, "99/99/9999"));
               }
               else
               {
                  A16TTBUS_FechaBaja = context.localUtil.CToD( cgiGet( edtTTBUS_FechaBaja_Internalname), 4) ;
                  n16TTBUS_FechaBaja = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16TTBUS_FechaBaja", context.localUtil.Format(A16TTBUS_FechaBaja, "99/99/9999"));
               }
               n16TTBUS_FechaBaja = ((DateTime.MinValue==A16TTBUS_FechaBaja) ? true : false) ;
               A43TTBUS_MotivoBaja = StringUtil.Upper( cgiGet( edtTTBUS_MotivoBaja_Internalname)) ;
               n43TTBUS_MotivoBaja = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TTBUS_MotivoBaja", A43TTBUS_MotivoBaja);
               n43TTBUS_MotivoBaja = (String.IsNullOrEmpty(StringUtil.RTrim( A43TTBUS_MotivoBaja)) ? true : false) ;
               A195TTBUS_UsuarioBaja = cgiGet( edtTTBUS_UsuarioBaja_Internalname) ;
               n195TTBUS_UsuarioBaja = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A195TTBUS_UsuarioBaja", A195TTBUS_UsuarioBaja);
               AV11TTBUS_UsuarioBaja = cgiGet( edtavTtbus_usuariobaja_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11TTBUS_UsuarioBaja", AV11TTBUS_UsuarioBaja);
               A196TTBUS_MaquinaBaja = cgiGet( edtTTBUS_MaquinaBaja_Internalname) ;
               n196TTBUS_MaquinaBaja = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A196TTBUS_MaquinaBaja", A196TTBUS_MaquinaBaja);
               AV10TTBUS_MaquinaBaja = cgiGet( edtavTtbus_maquinabaja_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10TTBUS_MaquinaBaja", AV10TTBUS_MaquinaBaja);
               /* Read saved values. */
               Z11TTBUS_Id = (int)(context.localUtil.CToN( cgiGet( "Z11TTBUS_Id"), ",", ".")) ;
               Z16TTBUS_FechaBaja = context.localUtil.CToD( cgiGet( "Z16TTBUS_FechaBaja"), 0) ;
               Z43TTBUS_MotivoBaja = cgiGet( "Z43TTBUS_MotivoBaja") ;
               Z195TTBUS_UsuarioBaja = cgiGet( "Z195TTBUS_UsuarioBaja") ;
               Z196TTBUS_MaquinaBaja = cgiGet( "Z196TTBUS_MaquinaBaja") ;
               Z23TTBUS_Estado = (short)(context.localUtil.CToN( cgiGet( "Z23TTBUS_Estado"), ",", ".")) ;
               A23TTBUS_Estado = (short)(context.localUtil.CToN( cgiGet( "Z23TTBUS_Estado"), ",", ".")) ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", ".")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", ".")) ;
               Gx_mode = cgiGet( "Mode") ;
               AV7SISTEMA = cgiGet( "vSISTEMA") ;
               AV9USUARIO = cgiGet( "vUSUARIO") ;
               AV8TTBUS_Id = (int)(context.localUtil.CToN( cgiGet( "vTTBUS_ID"), ",", ".")) ;
               A11TTBUS_Id = (int)(context.localUtil.CToN( cgiGet( "TTBUS_ID"), ",", ".")) ;
               Gx_BScreen = (short)(context.localUtil.CToN( cgiGet( "vGXBSCREEN"), ",", ".")) ;
               A23TTBUS_Estado = (short)(context.localUtil.CToN( cgiGet( "TTBUS_ESTADO"), ",", ".")) ;
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
                  A11TTBUS_Id = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
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
                     sMode1 = Gx_mode ;
                     Gx_mode = "UPD" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Gx_mode = sMode1 ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound1 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_030( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert"), 1, "");
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
               if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
               {
                  if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                  {
                     sEvtType = StringUtil.Right( sEvt, 1) ;
                     if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                     {
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                        if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E11032 */
                           E11032 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E12032 */
                           E12032 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_enter( ) ;
                           /* No code required for Cancel button. It is implemented as the Reset button. */
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
            /* Execute user event: E12032 */
            E12032 ();
            trnEnded = 0 ;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll031( ) ;
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
         bttBtn_delete_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            bttBtn_delete_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
            if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
            {
               bttBtn_enter_Visible = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)));
            }
            edtTTBUS_FechaBaja_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS_FechaBaja_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS_FechaBaja_Enabled), 5, 0)));
            edtTTBUS_MotivoBaja_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS_MotivoBaja_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS_MotivoBaja_Enabled), 5, 0)));
            edtTTBUS_UsuarioBaja_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS_UsuarioBaja_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS_UsuarioBaja_Enabled), 5, 0)));
            edtavTtbus_usuariobaja_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTtbus_usuariobaja_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus_usuariobaja_Enabled), 5, 0)));
            edtTTBUS_MaquinaBaja_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS_MaquinaBaja_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS_MaquinaBaja_Enabled), 5, 0)));
            edtavTtbus_maquinabaja_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTtbus_maquinabaja_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus_maquinabaja_Enabled), 5, 0)));
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

      protected void CONFIRM_030( )
      {
         BeforeValidate031( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls031( ) ;
            }
            else
            {
               CheckExtendedTable031( ) ;
               CloseExtendedTableCursors031( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1 ;
         }
      }

      protected void ResetCaption030( )
      {
      }

      protected void E11032( )
      {
         /* Start Routine */
         edtavTtbus_usuariobaja_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTtbus_usuariobaja_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus_usuariobaja_Enabled), 5, 0)));
         edtavTtbus_maquinabaja_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTtbus_maquinabaja_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus_maquinabaja_Enabled), 5, 0)));
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            AV11TTBUS_UsuarioBaja = AV9USUARIO ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11TTBUS_UsuarioBaja", AV11TTBUS_UsuarioBaja);
            AV10TTBUS_MaquinaBaja = GXUtil.WrkSt( context) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10TTBUS_MaquinaBaja", AV10TTBUS_MaquinaBaja);
            edtavTtbus_usuariobaja_Visible = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTtbus_usuariobaja_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus_usuariobaja_Visible), 5, 0)));
            edtavTtbus_maquinabaja_Visible = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTtbus_maquinabaja_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus_maquinabaja_Visible), 5, 0)));
            edtTTBUS_UsuarioBaja_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS_UsuarioBaja_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS_UsuarioBaja_Visible), 5, 0)));
            edtTTBUS_MaquinaBaja_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS_MaquinaBaja_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS_MaquinaBaja_Visible), 5, 0)));
         }
         else
         {
            edtavTtbus_usuariobaja_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTtbus_usuariobaja_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus_usuariobaja_Visible), 5, 0)));
            edtavTtbus_maquinabaja_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTtbus_maquinabaja_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus_maquinabaja_Visible), 5, 0)));
            edtTTBUS_UsuarioBaja_Visible = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS_UsuarioBaja_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS_UsuarioBaja_Visible), 5, 0)));
            edtTTBUS_MaquinaBaja_Visible = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS_MaquinaBaja_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS_MaquinaBaja_Visible), 5, 0)));
         }
      }

      protected void E12032( )
      {
         /* After Trn Routine */
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            new ptbus000_b_1(context ).execute( ref  AV8TTBUS_Id, ref  AV9USUARIO) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8TTBUS_Id), 8, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9USUARIO", AV9USUARIO);
         }
      }

      protected void ZM031( short GX_JID )
      {
         if ( ( GX_JID == 9 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z16TTBUS_FechaBaja = T00033_A16TTBUS_FechaBaja[0] ;
               Z43TTBUS_MotivoBaja = T00033_A43TTBUS_MotivoBaja[0] ;
               Z195TTBUS_UsuarioBaja = T00033_A195TTBUS_UsuarioBaja[0] ;
               Z196TTBUS_MaquinaBaja = T00033_A196TTBUS_MaquinaBaja[0] ;
               Z23TTBUS_Estado = T00033_A23TTBUS_Estado[0] ;
            }
            else
            {
               Z16TTBUS_FechaBaja = A16TTBUS_FechaBaja ;
               Z43TTBUS_MotivoBaja = A43TTBUS_MotivoBaja ;
               Z195TTBUS_UsuarioBaja = A195TTBUS_UsuarioBaja ;
               Z196TTBUS_MaquinaBaja = A196TTBUS_MaquinaBaja ;
               Z23TTBUS_Estado = A23TTBUS_Estado ;
            }
         }
         if ( GX_JID == -9 )
         {
            Z11TTBUS_Id = A11TTBUS_Id ;
            Z16TTBUS_FechaBaja = A16TTBUS_FechaBaja ;
            Z43TTBUS_MotivoBaja = A43TTBUS_MotivoBaja ;
            Z195TTBUS_UsuarioBaja = A195TTBUS_UsuarioBaja ;
            Z196TTBUS_MaquinaBaja = A196TTBUS_MaquinaBaja ;
            Z23TTBUS_Estado = A23TTBUS_Estado ;
         }
      }

      protected void standaloneNotModal( )
      {
         edtTTBUS_UsuarioBaja_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS_UsuarioBaja_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS_UsuarioBaja_Enabled), 5, 0)));
         edtTTBUS_MaquinaBaja_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS_MaquinaBaja_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS_MaquinaBaja_Enabled), 5, 0)));
         Gx_BScreen = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         edtTTBUS_UsuarioBaja_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS_UsuarioBaja_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS_UsuarioBaja_Enabled), 5, 0)));
         edtTTBUS_MaquinaBaja_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS_MaquinaBaja_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS_MaquinaBaja_Enabled), 5, 0)));
         bttBtn_delete_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)));
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            A11TTBUS_Id = AV8TTBUS_Id ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
         }
      }

      protected void standaloneModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_enter_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)));
         }
         else
         {
            bttBtn_enter_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (0==A23TTBUS_Estado) && ( Gx_BScreen == 0 ) )
         {
            A23TTBUS_Estado = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
         }
      }

      protected void Load031( )
      {
         /* Using cursor T00034 */
         pr_default.execute(2, new Object[] {A11TTBUS_Id});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound1 = 1 ;
            A16TTBUS_FechaBaja = T00034_A16TTBUS_FechaBaja[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16TTBUS_FechaBaja", context.localUtil.Format(A16TTBUS_FechaBaja, "99/99/9999"));
            n16TTBUS_FechaBaja = T00034_n16TTBUS_FechaBaja[0] ;
            A43TTBUS_MotivoBaja = T00034_A43TTBUS_MotivoBaja[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TTBUS_MotivoBaja", A43TTBUS_MotivoBaja);
            n43TTBUS_MotivoBaja = T00034_n43TTBUS_MotivoBaja[0] ;
            A195TTBUS_UsuarioBaja = T00034_A195TTBUS_UsuarioBaja[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A195TTBUS_UsuarioBaja", A195TTBUS_UsuarioBaja);
            n195TTBUS_UsuarioBaja = T00034_n195TTBUS_UsuarioBaja[0] ;
            A196TTBUS_MaquinaBaja = T00034_A196TTBUS_MaquinaBaja[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A196TTBUS_MaquinaBaja", A196TTBUS_MaquinaBaja);
            n196TTBUS_MaquinaBaja = T00034_n196TTBUS_MaquinaBaja[0] ;
            A23TTBUS_Estado = T00034_A23TTBUS_Estado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
            ZM031( -9) ;
         }
         pr_default.close(2);
         OnLoadActions031( ) ;
      }

      protected void OnLoadActions031( )
      {
      }

      protected void CheckExtendedTable031( )
      {
         Gx_BScreen = 1 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal( ) ;
         if ( ! ( (DateTime.MinValue==A16TTBUS_FechaBaja) || ( A16TTBUS_FechaBaja >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Fecha de Baja fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
         if ( true /* After */ && (DateTime.MinValue==A16TTBUS_FechaBaja) )
         {
            GX_msglist.addItem("DEBE INGRESAR UNA FECHA DE BAJA.", 1, "");
            AnyError = 1 ;
         }
         if ( true /* After */ && ( A16TTBUS_FechaBaja < DateTimeUtil.Today( ) ) )
         {
            GX_msglist.addItem("LA FECHA DE BAJA NO PUEDE SER MENOR QUE LA FECHA DEL DÍA.", 1, "");
            AnyError = 1 ;
         }
         if ( true /* After */ && ( ( StringUtil.StrCmp(StringUtil.Trim( A43TTBUS_MotivoBaja), "") == 0 ) ) )
         {
            GX_msglist.addItem("DEBE INGRESAR UN MOTIVO DE BAJA.", 1, "");
            AnyError = 1 ;
         }
      }

      protected void CloseExtendedTableCursors031( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey031( )
      {
         /* Using cursor T00035 */
         pr_default.execute(3, new Object[] {A11TTBUS_Id});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound1 = 1 ;
         }
         else
         {
            RcdFound1 = 0 ;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00033 */
         pr_default.execute(1, new Object[] {A11TTBUS_Id});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM031( 9) ;
            RcdFound1 = 1 ;
            A11TTBUS_Id = T00033_A11TTBUS_Id[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
            A16TTBUS_FechaBaja = T00033_A16TTBUS_FechaBaja[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16TTBUS_FechaBaja", context.localUtil.Format(A16TTBUS_FechaBaja, "99/99/9999"));
            n16TTBUS_FechaBaja = T00033_n16TTBUS_FechaBaja[0] ;
            A43TTBUS_MotivoBaja = T00033_A43TTBUS_MotivoBaja[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TTBUS_MotivoBaja", A43TTBUS_MotivoBaja);
            n43TTBUS_MotivoBaja = T00033_n43TTBUS_MotivoBaja[0] ;
            A195TTBUS_UsuarioBaja = T00033_A195TTBUS_UsuarioBaja[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A195TTBUS_UsuarioBaja", A195TTBUS_UsuarioBaja);
            n195TTBUS_UsuarioBaja = T00033_n195TTBUS_UsuarioBaja[0] ;
            A196TTBUS_MaquinaBaja = T00033_A196TTBUS_MaquinaBaja[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A196TTBUS_MaquinaBaja", A196TTBUS_MaquinaBaja);
            n196TTBUS_MaquinaBaja = T00033_n196TTBUS_MaquinaBaja[0] ;
            A23TTBUS_Estado = T00033_A23TTBUS_Estado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
            Z11TTBUS_Id = A11TTBUS_Id ;
            sMode1 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            Load031( ) ;
            Gx_mode = sMode1 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound1 = 0 ;
            InitializeNonKey031( ) ;
            sMode1 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode1 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey031( ) ;
         if ( RcdFound1 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound1 = 0 ;
         /* Using cursor T00036 */
         pr_default.execute(4, new Object[] {A11TTBUS_Id});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T00036_A11TTBUS_Id[0] < A11TTBUS_Id ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T00036_A11TTBUS_Id[0] > A11TTBUS_Id ) ) )
            {
               A11TTBUS_Id = T00036_A11TTBUS_Id[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
               RcdFound1 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound1 = 0 ;
         /* Using cursor T00037 */
         pr_default.execute(5, new Object[] {A11TTBUS_Id});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T00037_A11TTBUS_Id[0] > A11TTBUS_Id ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T00037_A11TTBUS_Id[0] < A11TTBUS_Id ) ) )
            {
               A11TTBUS_Id = T00037_A11TTBUS_Id[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
               RcdFound1 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey031( ) ;
         if ( RcdFound1 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "");
               AnyError = 1 ;
            }
            else if ( A11TTBUS_Id != Z11TTBUS_Id )
            {
               A11TTBUS_Id = Z11TTBUS_Id ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "CandidateKeyNotFound", 1, "");
               AnyError = 1 ;
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtTTBUS_FechaBaja_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               /* Update record */
               Update031( ) ;
               GX_FocusControl = edtTTBUS_FechaBaja_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( A11TTBUS_Id != Z11TTBUS_Id )
            {
               /* Insert record */
               Insert031( ) ;
               GX_FocusControl = edtTTBUS_FechaBaja_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "");
                  AnyError = 1 ;
               }
               else
               {
                  /* Insert record */
                  Insert031( ) ;
                  GX_FocusControl = edtTTBUS_FechaBaja_Internalname ;
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
         if ( A11TTBUS_Id != Z11TTBUS_Id )
         {
            A11TTBUS_Id = Z11TTBUS_Id ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt"), 1, "");
            AnyError = 1 ;
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtTTBUS_FechaBaja_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency031( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00038 */
            pr_default.execute(6, new Object[] {A11TTBUS_Id});
            if ( (pr_default.getStatus(6) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TTBUS000"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(6) == 101) || ( Z16TTBUS_FechaBaja != T00038_A16TTBUS_FechaBaja[0] ) || ( StringUtil.StrCmp(Z43TTBUS_MotivoBaja, T00038_A43TTBUS_MotivoBaja[0]) != 0 ) || ( StringUtil.StrCmp(Z195TTBUS_UsuarioBaja, T00038_A195TTBUS_UsuarioBaja[0]) != 0 ) || ( StringUtil.StrCmp(Z196TTBUS_MaquinaBaja, T00038_A196TTBUS_MaquinaBaja[0]) != 0 ) || ( Z23TTBUS_Estado != T00038_A23TTBUS_Estado[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"TTBUS000"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert031( )
      {
         BeforeValidate031( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable031( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM031( 0) ;
            CheckOptimisticConcurrency031( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm031( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert031( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00039 */
                     pr_default.execute(7, new Object[] {n16TTBUS_FechaBaja, A16TTBUS_FechaBaja, n43TTBUS_MotivoBaja, A43TTBUS_MotivoBaja, n195TTBUS_UsuarioBaja, A195TTBUS_UsuarioBaja, n196TTBUS_MaquinaBaja, A196TTBUS_MaquinaBaja, A23TTBUS_Estado});
                     pr_default.close(7);
                     /* Retrieving last key number assigned */
                     /* Using cursor T000310 */
                     pr_default.execute(8);
                     A11TTBUS_Id = T000310_A11TTBUS_Id[0] ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
                     pr_default.close(8);
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded"), 0, "");
                           ResetCaption030( ) ;
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
               Load031( ) ;
            }
            EndLevel031( ) ;
         }
         CloseExtendedTableCursors031( ) ;
      }

      protected void Update031( )
      {
         BeforeValidate031( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable031( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency031( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm031( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate031( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000311 */
                     pr_default.execute(9, new Object[] {n16TTBUS_FechaBaja, A16TTBUS_FechaBaja, n43TTBUS_MotivoBaja, A43TTBUS_MotivoBaja, n195TTBUS_UsuarioBaja, A195TTBUS_UsuarioBaja, n196TTBUS_MaquinaBaja, A196TTBUS_MaquinaBaja, A23TTBUS_Estado, A11TTBUS_Id});
                     pr_default.close(9);
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TTBUS000"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate031( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
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
            EndLevel031( ) ;
         }
         CloseExtendedTableCursors031( ) ;
      }

      protected void DeferredUpdate031( )
      {
      }

      protected void delete( )
      {
         BeforeValidate031( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency031( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls031( ) ;
            AfterConfirm031( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete031( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000312 */
                  pr_default.execute(10, new Object[] {A11TTBUS_Id});
                  pr_default.close(10);
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
         sMode1 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel031( ) ;
         Gx_mode = sMode1 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls031( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000313 */
            pr_default.execute(11, new Object[] {A11TTBUS_Id});
            if ( (pr_default.getStatus(11) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Documentacion de Bienes de Uso"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(11);
            /* Using cursor T000314 */
            pr_default.execute(12, new Object[] {A11TTBUS_Id});
            if ( (pr_default.getStatus(12) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Identificadores de Bienes de Uso"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(12);
         }
      }

      protected void EndLevel031( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(6);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete031( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(5);
            pr_default.close(4);
            context.CommitDataStores("TTBUS000_b");
            if ( AnyError == 0 )
            {
               ConfirmValues030( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(5);
            pr_default.close(4);
            context.RollbackDataStores("TTBUS000_b");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart031( )
      {
         /* Using cursor T000315 */
         pr_default.execute(13);
         RcdFound1 = 0 ;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound1 = 1 ;
            A11TTBUS_Id = T000315_A11TTBUS_Id[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext031( )
      {
         pr_default.readNext(13);
         RcdFound1 = 0 ;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound1 = 1 ;
            A11TTBUS_Id = T000315_A11TTBUS_Id[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
         }
      }

      protected void ScanEnd031( )
      {
      }

      protected void AfterConfirm031( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert031( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate031( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete031( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete031( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate031( )
      {
         /* Before Validate Rules */
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues030( )
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("ttbus000_b.aspx") + "?" + UrlEncode("" +AV8TTBUS_Id) + "," + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV7SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV9USUARIO))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z11TTBUS_Id", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11TTBUS_Id), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z16TTBUS_FechaBaja", context.localUtil.DToC( Z16TTBUS_FechaBaja, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z43TTBUS_MotivoBaja", StringUtil.RTrim( Z43TTBUS_MotivoBaja));
         GxWebStd.gx_hidden_field( context, "Z195TTBUS_UsuarioBaja", StringUtil.RTrim( Z195TTBUS_UsuarioBaja));
         GxWebStd.gx_hidden_field( context, "Z196TTBUS_MaquinaBaja", StringUtil.RTrim( Z196TTBUS_MaquinaBaja));
         GxWebStd.gx_hidden_field( context, "Z23TTBUS_Estado", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z23TTBUS_Estado), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vSISTEMA", StringUtil.RTrim( AV7SISTEMA));
         GxWebStd.gx_hidden_field( context, "vUSUARIO", StringUtil.RTrim( AV9USUARIO));
         GxWebStd.gx_hidden_field( context, "vTTBUS_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8TTBUS_Id), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "TTBUS_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A11TTBUS_Id), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vGXBSCREEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gx_BScreen), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "TTBUS_ESTADO", StringUtil.LTrim( StringUtil.NToC( (decimal)(A23TTBUS_Estado), 1, 0, ",", "")));
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
         return "TTBUS000_b" ;
      }

      public override String GetPgmdesc( )
      {
         return "Baja de un Bien de Uso" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("ttbus000_b.aspx") + "?" + UrlEncode("" +AV8TTBUS_Id) + "," + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV7SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV9USUARIO)) ;
      }

      protected void InitializeNonKey031( )
      {
         A16TTBUS_FechaBaja = DateTime.MinValue ;
         n16TTBUS_FechaBaja = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16TTBUS_FechaBaja", context.localUtil.Format(A16TTBUS_FechaBaja, "99/99/9999"));
         n16TTBUS_FechaBaja = ((DateTime.MinValue==A16TTBUS_FechaBaja) ? true : false) ;
         A43TTBUS_MotivoBaja = "" ;
         n43TTBUS_MotivoBaja = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43TTBUS_MotivoBaja", A43TTBUS_MotivoBaja);
         n43TTBUS_MotivoBaja = (String.IsNullOrEmpty(StringUtil.RTrim( A43TTBUS_MotivoBaja)) ? true : false) ;
         A195TTBUS_UsuarioBaja = "" ;
         n195TTBUS_UsuarioBaja = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A195TTBUS_UsuarioBaja", A195TTBUS_UsuarioBaja);
         n195TTBUS_UsuarioBaja = (String.IsNullOrEmpty(StringUtil.RTrim( A195TTBUS_UsuarioBaja)) ? true : false) ;
         A196TTBUS_MaquinaBaja = "" ;
         n196TTBUS_MaquinaBaja = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A196TTBUS_MaquinaBaja", A196TTBUS_MaquinaBaja);
         n196TTBUS_MaquinaBaja = (String.IsNullOrEmpty(StringUtil.RTrim( A196TTBUS_MaquinaBaja)) ? true : false) ;
         A23TTBUS_Estado = 1 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
      }

      protected void InitAll031( )
      {
         A11TTBUS_Id = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
         InitializeNonKey031( ) ;
      }

      protected void StandaloneModalInsert( )
      {
         A23TTBUS_Estado = i23TTBUS_Estado ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?84120");
         AddThemeStyleSheetFile("", "Modern.css", "?2051812");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?13221551");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("ttbus000_b.js", "?13221551");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblockttbus_fechabaja_Internalname = "TEXTBLOCKTTBUS_FECHABAJA" ;
         edtTTBUS_FechaBaja_Internalname = "TTBUS_FECHABAJA" ;
         lblTextblockttbus_motivobaja_Internalname = "TEXTBLOCKTTBUS_MOTIVOBAJA" ;
         edtTTBUS_MotivoBaja_Internalname = "TTBUS_MOTIVOBAJA" ;
         lblTextblockttbus_motivobaja2_Internalname = "TEXTBLOCKTTBUS_MOTIVOBAJA2" ;
         edtTTBUS_UsuarioBaja_Internalname = "TTBUS_USUARIOBAJA" ;
         edtavTtbus_usuariobaja_Internalname = "vTTBUS_USUARIOBAJA" ;
         lblTextblockttbus_motivobaja3_Internalname = "TEXTBLOCKTTBUS_MOTIVOBAJA3" ;
         edtTTBUS_MaquinaBaja_Internalname = "TTBUS_MAQUINABAJA" ;
         edtavTtbus_maquinabaja_Internalname = "vTTBUS_MAQUINABAJA" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable4_Internalname = "TABLE4" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Baja de un Bien de Uso" ;
         edtavTtbus_maquinabaja_Jsonclick = "" ;
         edtavTtbus_maquinabaja_Enabled = 0 ;
         edtavTtbus_maquinabaja_Visible = 1 ;
         edtTTBUS_MaquinaBaja_Jsonclick = "" ;
         edtTTBUS_MaquinaBaja_Enabled = 0 ;
         edtTTBUS_MaquinaBaja_Visible = 1 ;
         edtavTtbus_usuariobaja_Jsonclick = "" ;
         edtavTtbus_usuariobaja_Enabled = 0 ;
         edtavTtbus_usuariobaja_Visible = 1 ;
         edtTTBUS_UsuarioBaja_Jsonclick = "" ;
         edtTTBUS_UsuarioBaja_Enabled = 0 ;
         edtTTBUS_UsuarioBaja_Visible = 1 ;
         edtTTBUS_MotivoBaja_Jsonclick = "" ;
         edtTTBUS_MotivoBaja_Enabled = 1 ;
         edtTTBUS_FechaBaja_Jsonclick = "" ;
         edtTTBUS_FechaBaja_Enabled = 1 ;
         bttBtn_delete_Enabled = 0 ;
         bttBtn_delete_Visible = 1 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_enter_Enabled = 1 ;
         bttBtn_enter_Visible = 1 ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
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
         pr_default.close(13);
         pr_default.close(5);
         pr_default.close(4);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         wcpOGx_mode = "" ;
         wcpOAV7SISTEMA = "" ;
         wcpOAV9USUARIO = "" ;
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
         lblTextblockttbus_fechabaja_Jsonclick = "" ;
         A16TTBUS_FechaBaja = DateTime.MinValue ;
         lblTextblockttbus_motivobaja_Jsonclick = "" ;
         A43TTBUS_MotivoBaja = "" ;
         lblTextblockttbus_motivobaja2_Jsonclick = "" ;
         A195TTBUS_UsuarioBaja = "" ;
         AV11TTBUS_UsuarioBaja = "" ;
         lblTextblockttbus_motivobaja3_Jsonclick = "" ;
         A196TTBUS_MaquinaBaja = "" ;
         AV10TTBUS_MaquinaBaja = "" ;
         Z16TTBUS_FechaBaja = DateTime.MinValue ;
         Z43TTBUS_MotivoBaja = "" ;
         Z195TTBUS_UsuarioBaja = "" ;
         Z196TTBUS_MaquinaBaja = "" ;
         sMode1 = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         T00034_A11TTBUS_Id = new int[1] ;
         T00034_A16TTBUS_FechaBaja = new DateTime[] {DateTime.MinValue} ;
         T00034_n16TTBUS_FechaBaja = new bool[] {false} ;
         T00034_A43TTBUS_MotivoBaja = new String[] {""} ;
         T00034_n43TTBUS_MotivoBaja = new bool[] {false} ;
         T00034_A195TTBUS_UsuarioBaja = new String[] {""} ;
         T00034_n195TTBUS_UsuarioBaja = new bool[] {false} ;
         T00034_A196TTBUS_MaquinaBaja = new String[] {""} ;
         T00034_n196TTBUS_MaquinaBaja = new bool[] {false} ;
         T00034_A23TTBUS_Estado = new short[1] ;
         T00035_A11TTBUS_Id = new int[1] ;
         T00033_A11TTBUS_Id = new int[1] ;
         T00033_A16TTBUS_FechaBaja = new DateTime[] {DateTime.MinValue} ;
         T00033_n16TTBUS_FechaBaja = new bool[] {false} ;
         T00033_A43TTBUS_MotivoBaja = new String[] {""} ;
         T00033_n43TTBUS_MotivoBaja = new bool[] {false} ;
         T00033_A195TTBUS_UsuarioBaja = new String[] {""} ;
         T00033_n195TTBUS_UsuarioBaja = new bool[] {false} ;
         T00033_A196TTBUS_MaquinaBaja = new String[] {""} ;
         T00033_n196TTBUS_MaquinaBaja = new bool[] {false} ;
         T00033_A23TTBUS_Estado = new short[1] ;
         T00036_A11TTBUS_Id = new int[1] ;
         T00037_A11TTBUS_Id = new int[1] ;
         T00038_A11TTBUS_Id = new int[1] ;
         T00038_A16TTBUS_FechaBaja = new DateTime[] {DateTime.MinValue} ;
         T00038_n16TTBUS_FechaBaja = new bool[] {false} ;
         T00038_A43TTBUS_MotivoBaja = new String[] {""} ;
         T00038_n43TTBUS_MotivoBaja = new bool[] {false} ;
         T00038_A195TTBUS_UsuarioBaja = new String[] {""} ;
         T00038_n195TTBUS_UsuarioBaja = new bool[] {false} ;
         T00038_A196TTBUS_MaquinaBaja = new String[] {""} ;
         T00038_n196TTBUS_MaquinaBaja = new bool[] {false} ;
         T00038_A23TTBUS_Estado = new short[1] ;
         T000310_A11TTBUS_Id = new int[1] ;
         T000313_A11TTBUS_Id = new int[1] ;
         T000313_A64DocuId = new int[1] ;
         T000314_A11TTBUS_Id = new int[1] ;
         T000314_A14IdIdentificador = new int[1] ;
         T000315_A11TTBUS_Id = new int[1] ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ttbus000_b__default(),
            new Object[][] {
                new Object[] {
               T00032_A11TTBUS_Id, T00032_A16TTBUS_FechaBaja, T00032_n16TTBUS_FechaBaja, T00032_A43TTBUS_MotivoBaja, T00032_n43TTBUS_MotivoBaja, T00032_A195TTBUS_UsuarioBaja, T00032_n195TTBUS_UsuarioBaja, T00032_A196TTBUS_MaquinaBaja, T00032_n196TTBUS_MaquinaBaja, T00032_A23TTBUS_Estado
               }
               , new Object[] {
               T00033_A11TTBUS_Id, T00033_A16TTBUS_FechaBaja, T00033_n16TTBUS_FechaBaja, T00033_A43TTBUS_MotivoBaja, T00033_n43TTBUS_MotivoBaja, T00033_A195TTBUS_UsuarioBaja, T00033_n195TTBUS_UsuarioBaja, T00033_A196TTBUS_MaquinaBaja, T00033_n196TTBUS_MaquinaBaja, T00033_A23TTBUS_Estado
               }
               , new Object[] {
               T00034_A11TTBUS_Id, T00034_A16TTBUS_FechaBaja, T00034_n16TTBUS_FechaBaja, T00034_A43TTBUS_MotivoBaja, T00034_n43TTBUS_MotivoBaja, T00034_A195TTBUS_UsuarioBaja, T00034_n195TTBUS_UsuarioBaja, T00034_A196TTBUS_MaquinaBaja, T00034_n196TTBUS_MaquinaBaja, T00034_A23TTBUS_Estado
               }
               , new Object[] {
               T00035_A11TTBUS_Id
               }
               , new Object[] {
               T00036_A11TTBUS_Id
               }
               , new Object[] {
               T00037_A11TTBUS_Id
               }
               , new Object[] {
               T00038_A11TTBUS_Id, T00038_A16TTBUS_FechaBaja, T00038_n16TTBUS_FechaBaja, T00038_A43TTBUS_MotivoBaja, T00038_n43TTBUS_MotivoBaja, T00038_A195TTBUS_UsuarioBaja, T00038_n195TTBUS_UsuarioBaja, T00038_A196TTBUS_MaquinaBaja, T00038_n196TTBUS_MaquinaBaja, T00038_A23TTBUS_Estado
               }
               , new Object[] {
               }
               , new Object[] {
               T000310_A11TTBUS_Id
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000313_A11TTBUS_Id, T000313_A64DocuId
               }
               , new Object[] {
               T000314_A11TTBUS_Id, T000314_A14IdIdentificador
               }
               , new Object[] {
               T000315_A11TTBUS_Id
               }
            }
         );
         Z23TTBUS_Estado = 1 ;
      }

      private short GxWebError ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short Z23TTBUS_Estado ;
      private short A23TTBUS_Estado ;
      private short Gx_BScreen ;
      private short RcdFound1 ;
      private short GX_JID ;
      private short gxajaxcallmode ;
      private short i23TTBUS_Estado ;
      private int wcpOAV8TTBUS_Id ;
      private int AV8TTBUS_Id ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtTTBUS_FechaBaja_Enabled ;
      private int edtTTBUS_MotivoBaja_Enabled ;
      private int edtTTBUS_UsuarioBaja_Visible ;
      private int edtTTBUS_UsuarioBaja_Enabled ;
      private int edtavTtbus_usuariobaja_Visible ;
      private int edtavTtbus_usuariobaja_Enabled ;
      private int edtTTBUS_MaquinaBaja_Visible ;
      private int edtTTBUS_MaquinaBaja_Enabled ;
      private int edtavTtbus_maquinabaja_Visible ;
      private int edtavTtbus_maquinabaja_Enabled ;
      private int Z11TTBUS_Id ;
      private int A11TTBUS_Id ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String wcpOAV7SISTEMA ;
      private String wcpOAV9USUARIO ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String AV7SISTEMA ;
      private String AV9USUARIO ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtTTBUS_FechaBaja_Internalname ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String grpGroupdata_Internalname ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockttbus_fechabaja_Internalname ;
      private String lblTextblockttbus_fechabaja_Jsonclick ;
      private String edtTTBUS_FechaBaja_Jsonclick ;
      private String lblTextblockttbus_motivobaja_Internalname ;
      private String lblTextblockttbus_motivobaja_Jsonclick ;
      private String edtTTBUS_MotivoBaja_Internalname ;
      private String edtTTBUS_MotivoBaja_Jsonclick ;
      private String lblTextblockttbus_motivobaja2_Internalname ;
      private String lblTextblockttbus_motivobaja2_Jsonclick ;
      private String edtTTBUS_UsuarioBaja_Internalname ;
      private String A195TTBUS_UsuarioBaja ;
      private String edtTTBUS_UsuarioBaja_Jsonclick ;
      private String edtavTtbus_usuariobaja_Internalname ;
      private String AV11TTBUS_UsuarioBaja ;
      private String edtavTtbus_usuariobaja_Jsonclick ;
      private String lblTextblockttbus_motivobaja3_Internalname ;
      private String lblTextblockttbus_motivobaja3_Jsonclick ;
      private String edtTTBUS_MaquinaBaja_Internalname ;
      private String A196TTBUS_MaquinaBaja ;
      private String edtTTBUS_MaquinaBaja_Jsonclick ;
      private String edtavTtbus_maquinabaja_Internalname ;
      private String AV10TTBUS_MaquinaBaja ;
      private String edtavTtbus_maquinabaja_Jsonclick ;
      private String Z195TTBUS_UsuarioBaja ;
      private String Z196TTBUS_MaquinaBaja ;
      private String sMode1 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private DateTime A16TTBUS_FechaBaja ;
      private DateTime Z16TTBUS_FechaBaja ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool n16TTBUS_FechaBaja ;
      private bool n43TTBUS_MotivoBaja ;
      private bool n195TTBUS_UsuarioBaja ;
      private bool n196TTBUS_MaquinaBaja ;
      private String A43TTBUS_MotivoBaja ;
      private String Z43TTBUS_MotivoBaja ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private int aP0_TTBUS_Id ;
      private String aP1_Gx_mode ;
      private String aP2_SISTEMA ;
      private String aP3_USUARIO ;
      private IDataStoreProvider pr_default ;
      private int[] T00034_A11TTBUS_Id ;
      private DateTime[] T00034_A16TTBUS_FechaBaja ;
      private bool[] T00034_n16TTBUS_FechaBaja ;
      private String[] T00034_A43TTBUS_MotivoBaja ;
      private bool[] T00034_n43TTBUS_MotivoBaja ;
      private String[] T00034_A195TTBUS_UsuarioBaja ;
      private bool[] T00034_n195TTBUS_UsuarioBaja ;
      private String[] T00034_A196TTBUS_MaquinaBaja ;
      private bool[] T00034_n196TTBUS_MaquinaBaja ;
      private short[] T00034_A23TTBUS_Estado ;
      private int[] T00035_A11TTBUS_Id ;
      private int[] T00033_A11TTBUS_Id ;
      private DateTime[] T00033_A16TTBUS_FechaBaja ;
      private bool[] T00033_n16TTBUS_FechaBaja ;
      private String[] T00033_A43TTBUS_MotivoBaja ;
      private bool[] T00033_n43TTBUS_MotivoBaja ;
      private String[] T00033_A195TTBUS_UsuarioBaja ;
      private bool[] T00033_n195TTBUS_UsuarioBaja ;
      private String[] T00033_A196TTBUS_MaquinaBaja ;
      private bool[] T00033_n196TTBUS_MaquinaBaja ;
      private short[] T00033_A23TTBUS_Estado ;
      private int[] T00036_A11TTBUS_Id ;
      private int[] T00037_A11TTBUS_Id ;
      private int[] T00038_A11TTBUS_Id ;
      private DateTime[] T00038_A16TTBUS_FechaBaja ;
      private bool[] T00038_n16TTBUS_FechaBaja ;
      private String[] T00038_A43TTBUS_MotivoBaja ;
      private bool[] T00038_n43TTBUS_MotivoBaja ;
      private String[] T00038_A195TTBUS_UsuarioBaja ;
      private bool[] T00038_n195TTBUS_UsuarioBaja ;
      private String[] T00038_A196TTBUS_MaquinaBaja ;
      private bool[] T00038_n196TTBUS_MaquinaBaja ;
      private short[] T00038_A23TTBUS_Estado ;
      private int[] T000310_A11TTBUS_Id ;
      private int[] T000313_A11TTBUS_Id ;
      private int[] T000313_A64DocuId ;
      private int[] T000314_A11TTBUS_Id ;
      private int[] T000314_A14IdIdentificador ;
      private int[] T000315_A11TTBUS_Id ;
      private int[] T00032_A11TTBUS_Id ;
      private DateTime[] T00032_A16TTBUS_FechaBaja ;
      private String[] T00032_A43TTBUS_MotivoBaja ;
      private String[] T00032_A195TTBUS_UsuarioBaja ;
      private String[] T00032_A196TTBUS_MaquinaBaja ;
      private short[] T00032_A23TTBUS_Estado ;
      private bool[] T00032_n16TTBUS_FechaBaja ;
      private bool[] T00032_n43TTBUS_MotivoBaja ;
      private bool[] T00032_n195TTBUS_UsuarioBaja ;
      private bool[] T00032_n196TTBUS_MaquinaBaja ;
      private GXWebForm Form ;
   }

   public class ttbus000_b__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[8])
         ,new UpdateCursor(def[9])
         ,new UpdateCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00032 ;
          prmT00032 = new Object[] {
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmT00034 ;
          prmT00034 = new Object[] {
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmT00035 ;
          prmT00035 = new Object[] {
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmT00033 ;
          prmT00033 = new Object[] {
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmT00036 ;
          prmT00036 = new Object[] {
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmT00037 ;
          prmT00037 = new Object[] {
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmT00038 ;
          prmT00038 = new Object[] {
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmT00039 ;
          prmT00039 = new Object[] {
          new Object[] {"@TTBUS_FechaBaja",SqlDbType.DateTime,8,0} ,
          new Object[] {"@TTBUS_MotivoBaja",SqlDbType.VarChar,50,0} ,
          new Object[] {"@TTBUS_UsuarioBaja",SqlDbType.Char,15,0} ,
          new Object[] {"@TTBUS_MaquinaBaja",SqlDbType.Char,20,0} ,
          new Object[] {"@TTBUS_Estado",SqlDbType.SmallInt,1,0}
          } ;
          Object[] prmT000310 ;
          prmT000310 = new Object[] {
          } ;
          Object[] prmT000311 ;
          prmT000311 = new Object[] {
          new Object[] {"@TTBUS_FechaBaja",SqlDbType.DateTime,8,0} ,
          new Object[] {"@TTBUS_MotivoBaja",SqlDbType.VarChar,50,0} ,
          new Object[] {"@TTBUS_UsuarioBaja",SqlDbType.Char,15,0} ,
          new Object[] {"@TTBUS_MaquinaBaja",SqlDbType.Char,20,0} ,
          new Object[] {"@TTBUS_Estado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000312 ;
          prmT000312 = new Object[] {
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000313 ;
          prmT000313 = new Object[] {
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000314 ;
          prmT000314 = new Object[] {
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000315 ;
          prmT000315 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T00032", "SELECT [TTBUS_Id], [TTBUS_FechaBaja], [TTBUS_MotivoBaja], [TTBUS_UsuarioBaja], [TTBUS_MaquinaBaja], [TTBUS_Estado] FROM [TTBUS000] WITH (UPDLOCK) WHERE [TTBUS_Id] = @TTBUS_Id ",true, GxErrorMask.GX_NOMASK, false, this,prmT00032,1,0,true,false )
             ,new CursorDef("T00033", "SELECT [TTBUS_Id], [TTBUS_FechaBaja], [TTBUS_MotivoBaja], [TTBUS_UsuarioBaja], [TTBUS_MaquinaBaja], [TTBUS_Estado] FROM [TTBUS000] WITH (NOLOCK) WHERE [TTBUS_Id] = @TTBUS_Id ",true, GxErrorMask.GX_NOMASK, false, this,prmT00033,1,0,true,false )
             ,new CursorDef("T00034", "SELECT TM1.[TTBUS_Id], TM1.[TTBUS_FechaBaja], TM1.[TTBUS_MotivoBaja], TM1.[TTBUS_UsuarioBaja], TM1.[TTBUS_MaquinaBaja], TM1.[TTBUS_Estado] FROM [TTBUS000] TM1 WITH (NOLOCK) WHERE TM1.[TTBUS_Id] = @TTBUS_Id ORDER BY TM1.[TTBUS_Id]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00034,100,0,true,false )
             ,new CursorDef("T00035", "SELECT [TTBUS_Id] FROM [TTBUS000] WITH (NOLOCK) WHERE [TTBUS_Id] = @TTBUS_Id  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00035,1,0,true,false )
             ,new CursorDef("T00036", "SELECT TOP 1 [TTBUS_Id] FROM [TTBUS000] WITH (NOLOCK) WHERE ( [TTBUS_Id] > @TTBUS_Id) ORDER BY [TTBUS_Id]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00036,1,0,true,true )
             ,new CursorDef("T00037", "SELECT TOP 1 [TTBUS_Id] FROM [TTBUS000] WITH (NOLOCK) WHERE ( [TTBUS_Id] < @TTBUS_Id) ORDER BY [TTBUS_Id] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00037,1,0,true,true )
             ,new CursorDef("T00038", "SELECT [TTBUS_Id], [TTBUS_FechaBaja], [TTBUS_MotivoBaja], [TTBUS_UsuarioBaja], [TTBUS_MaquinaBaja], [TTBUS_Estado] FROM [TTBUS000] WITH (UPDLOCK) WHERE [TTBUS_Id] = @TTBUS_Id ",true, GxErrorMask.GX_NOMASK, false, this,prmT00038,1,0,true,false )
             ,new CursorDef("T00039", "INSERT INTO [TTBUS000] ([TTBUS_FechaBaja], [TTBUS_MotivoBaja], [TTBUS_UsuarioBaja], [TTBUS_MaquinaBaja], [TTBUS_Estado], [TTBUS_Descripcion], [TTBUS_FechaCarga], [TTBUS_CodProveedor], [TTBUS_Alquilado], [TTBUS_CodPosicion], [TTBUS_DesPosicion], [TTBUS_RubroBien], [TTBUS_ContDocu], [TTBUS_UsuarioAlta], [TTBUS_MaquinaAlta], [TTBUS_NroSerie]) VALUES (@TTBUS_FechaBaja, @TTBUS_MotivoBaja, @TTBUS_UsuarioBaja, @TTBUS_MaquinaBaja, @TTBUS_Estado, '', convert( DATETIME, '17530101', 112 ), convert(int, 0), convert(int, 0), convert(int, 0), '', convert(int, 0), convert(int, 0), '', '', '')", GxErrorMask.GX_NOMASK,prmT00039)
             ,new CursorDef("T000310", "SELECT Ident_Current('[TTBUS000]') ",true, GxErrorMask.GX_NOMASK, false, this,prmT000310,1,0,true,false )
             ,new CursorDef("T000311", "UPDATE [TTBUS000] SET [TTBUS_FechaBaja]=@TTBUS_FechaBaja, [TTBUS_MotivoBaja]=@TTBUS_MotivoBaja, [TTBUS_UsuarioBaja]=@TTBUS_UsuarioBaja, [TTBUS_MaquinaBaja]=@TTBUS_MaquinaBaja, [TTBUS_Estado]=@TTBUS_Estado  WHERE [TTBUS_Id] = @TTBUS_Id", GxErrorMask.GX_NOMASK,prmT000311)
             ,new CursorDef("T000312", "DELETE FROM [TTBUS000]  WHERE [TTBUS_Id] = @TTBUS_Id", GxErrorMask.GX_NOMASK,prmT000312)
             ,new CursorDef("T000313", "SELECT TOP 1 [TTBUS_Id], [DocuId] FROM [TTBUS000Documentacion] WITH (NOLOCK) WHERE [TTBUS_Id] = @TTBUS_Id ",true, GxErrorMask.GX_NOMASK, false, this,prmT000313,1,0,true,true )
             ,new CursorDef("T000314", "SELECT TOP 1 [TTBUS_Id], [IdIdentificador] FROM [TTBUS000Identificadores] WITH (NOLOCK) WHERE [TTBUS_Id] = @TTBUS_Id ",true, GxErrorMask.GX_NOMASK, false, this,prmT000314,1,0,true,true )
             ,new CursorDef("T000315", "SELECT [TTBUS_Id] FROM [TTBUS000] WITH (NOLOCK) ORDER BY [TTBUS_Id]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000315,100,0,true,false )
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
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getString(4, 15) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getString(5, 20) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((short[]) buf[9])[0] = rslt.getShort(6) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getString(4, 15) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getString(5, 20) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((short[]) buf[9])[0] = rslt.getShort(6) ;
                break;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getString(4, 15) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getString(5, 20) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((short[]) buf[9])[0] = rslt.getShort(6) ;
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
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getString(4, 15) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getString(5, 20) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((short[]) buf[9])[0] = rslt.getShort(6) ;
                break;
             case 8 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 11 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 12 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 13 :
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
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(1, (DateTime)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[7]);
                }
                stmt.SetParameter(5, (short)parms[8]);
                break;
             case 9 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(1, (DateTime)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[7]);
                }
                stmt.SetParameter(5, (short)parms[8]);
                stmt.SetParameter(6, (int)parms[9]);
                break;
             case 10 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 11 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 12 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
       }
    }

 }

}
