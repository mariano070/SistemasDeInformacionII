/*
               File: TT53FPOS
        Description: Posiciones Sistema Trazabilidad
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 3/17/2014 13:22:48.19
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
   public class tt53fpos : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            AV9W53POS = (short)(NumberUtil.Val( gxfirstwebparm, ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9W53POS", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9W53POS), 3, 0)));
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
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Posiciones Sistema Trazabilidad", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtW53POS_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Modern");
      }

      public tt53fpos( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public tt53fpos( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref short aP0_W53POS ,
                           ref String aP1_Gx_mode ,
                           ref String aP2_SISTEMA ,
                           ref String aP3_USUARIO )
      {
         this.AV9W53POS = aP0_W53POS;
         this.Gx_mode = aP1_Gx_mode;
         this.AV7SISTEMA = aP2_SISTEMA;
         this.AV8USUARIO = aP3_USUARIO;
         executePrivate();
         aP0_W53POS=this.AV9W53POS;
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
            wb_table1_2_0W31( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_0W31e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_0W31( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_0W31( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_0W31e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+""+"</legend>") ;
            wb_table3_11_0W31( true) ;
         }
         return  ;
      }

      protected void wb_table3_11_0W31e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0W31e( true) ;
         }
         else
         {
            wb_table1_2_0W31e( false) ;
         }
      }

      protected void wb_table3_11_0W31( bool wbgen )
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
            wb_table4_17_0W31( true) ;
         }
         return  ;
      }

      protected void wb_table4_17_0W31e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_enter_Internalname, "Confirmar", "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "rounded", 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "HLP_TT53FPOS.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 31,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "HLP_TT53FPOS.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 32,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_delete_Internalname, "Eliminar", "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "rounded", 5, bttBtn_delete_Jsonclick, "EDELETE.", TempTags, "", "", "HLP_TT53FPOS.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_11_0W31e( true) ;
         }
         else
         {
            wb_table3_11_0W31e( false) ;
         }
      }

      protected void wb_table4_17_0W31( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockw53pos_Internalname, 1, 1, 0, "Id. Posición", "", "", "", 0, lblTextblockw53pos_Jsonclick, "", StyleString, ClassString, "HLP_TT53FPOS.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtW53POS_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A31W53POS), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, edtW53POS_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A31W53POS), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(22);\"", 0, edtW53POS_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TT53FPOS.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockw53des_Internalname, 1, 1, 0, "Descripción", "", "", "", 0, lblTextblockw53des_Jsonclick, "", StyleString, ClassString, "HLP_TT53FPOS.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtW53DES_Internalname, StringUtil.RTrim( A32W53DES), "", 50, "chr", 1, "row", 50, 1, edtW53DES_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A32W53DES, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(27);\"", 0, edtW53DES_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TT53FPOS.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_17_0W31e( true) ;
         }
         else
         {
            wb_table4_17_0W31e( false) ;
         }
      }

      protected void wb_table2_5_0W31( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTabletoolbar_Internalname, tblTabletoolbar_Internalname, "", "ViewTable", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "<div style=\"WHITE-SPACE: nowrap\" class=\"ToolbarMain\" id=\"Section1\">") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 8,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TT53FPOS.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00v0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"W53POS"+"'), id:'"+"W53POS"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");"+"return false;", "HLP_TT53FPOS.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_5_0W31e( true) ;
         }
         else
         {
            wb_table2_5_0W31e( false) ;
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
               if ( ! context.localUtil.VCNumber( cgiGet( edtW53POS_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtW53POS_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtW53POS_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "W53POS");
                  AnyError = 1 ;
                  GX_FocusControl = edtW53POS_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A31W53POS = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31W53POS", StringUtil.LTrim( StringUtil.Str( (decimal)(A31W53POS), 3, 0)));
               }
               else
               {
                  A31W53POS = (short)(context.localUtil.CToN( cgiGet( edtW53POS_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31W53POS", StringUtil.LTrim( StringUtil.Str( (decimal)(A31W53POS), 3, 0)));
               }
               A32W53DES = cgiGet( edtW53DES_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32W53DES", A32W53DES);
               /* Read saved values. */
               Z31W53POS = (short)(context.localUtil.CToN( cgiGet( "Z31W53POS"), ",", ".")) ;
               Z32W53DES = cgiGet( "Z32W53DES") ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", ".")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", ".")) ;
               Gx_mode = cgiGet( "Mode") ;
               AV7SISTEMA = cgiGet( "vSISTEMA") ;
               AV8USUARIO = cgiGet( "vUSUARIO") ;
               AV9W53POS = (short)(context.localUtil.CToN( cgiGet( "vW53POS"), ",", ".")) ;
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
                  A31W53POS = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31W53POS", StringUtil.LTrim( StringUtil.Str( (decimal)(A31W53POS), 3, 0)));
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
                     sMode31 = Gx_mode ;
                     Gx_mode = "UPD" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Gx_mode = sMode31 ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound31 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0W0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert"), 1, "W53POS");
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
                        if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_enter( ) ;
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                        {
                           context.wbHandled = 1 ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "SELECT") == 0 )
                        {
                           context.wbHandled = 1 ;
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
               InitAll0W31( ) ;
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
         imgBtn_next_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_next_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_next_separator_Visible), 5, 0)));
         imgBtn_select_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_select_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_select_separator_Visible), 5, 0)));
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            bttBtn_delete_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
            if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
            {
               bttBtn_enter_Visible = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)));
            }
            edtW53POS_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtW53POS_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtW53POS_Enabled), 5, 0)));
            edtW53DES_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtW53DES_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtW53DES_Enabled), 5, 0)));
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

      protected void CONFIRM_0W0( )
      {
         BeforeValidate0W31( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0W31( ) ;
            }
            else
            {
               CheckExtendedTable0W31( ) ;
               CloseExtendedTableCursors0W31( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1 ;
         }
      }

      protected void ResetCaption0W0( )
      {
      }

      protected void ZM0W31( short GX_JID )
      {
         if ( ( GX_JID == 6 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z32W53DES = T000W3_A32W53DES[0] ;
            }
            else
            {
               Z32W53DES = A32W53DES ;
            }
         }
         if ( GX_JID == -6 )
         {
            Z31W53POS = A31W53POS ;
            Z32W53DES = A32W53DES ;
         }
      }

      protected void standaloneNotModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtW53POS_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtW53POS_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtW53POS_Enabled), 5, 0)));
         }
         else
         {
            edtW53POS_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtW53POS_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtW53POS_Enabled), 5, 0)));
         }
         bttBtn_delete_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)));
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            A31W53POS = AV9W53POS ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31W53POS", StringUtil.LTrim( StringUtil.Str( (decimal)(A31W53POS), 3, 0)));
         }
      }

      protected void standaloneModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtW53POS_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtW53POS_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtW53POS_Enabled), 5, 0)));
         }
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
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
         }
      }

      protected void Load0W31( )
      {
         /* Using cursor T000W4 */
         pr_default.execute(2, new Object[] {A31W53POS});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound31 = 1 ;
            A32W53DES = T000W4_A32W53DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32W53DES", A32W53DES);
            ZM0W31( -6) ;
         }
         pr_default.close(2);
         OnLoadActions0W31( ) ;
      }

      protected void OnLoadActions0W31( )
      {
      }

      protected void CheckExtendedTable0W31( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         if ( (0==A31W53POS) )
         {
            GX_msglist.addItem("La posición debe tener una código", 1, "");
            AnyError = 1 ;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A32W53DES)) )
         {
            GX_msglist.addItem("La posición debe tener una descripción", 1, "");
            AnyError = 1 ;
         }
      }

      protected void CloseExtendedTableCursors0W31( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0W31( )
      {
         /* Using cursor T000W5 */
         pr_default.execute(3, new Object[] {A31W53POS});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound31 = 1 ;
         }
         else
         {
            RcdFound31 = 0 ;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000W3 */
         pr_default.execute(1, new Object[] {A31W53POS});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0W31( 6) ;
            RcdFound31 = 1 ;
            A31W53POS = T000W3_A31W53POS[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31W53POS", StringUtil.LTrim( StringUtil.Str( (decimal)(A31W53POS), 3, 0)));
            A32W53DES = T000W3_A32W53DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32W53DES", A32W53DES);
            Z31W53POS = A31W53POS ;
            sMode31 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            Load0W31( ) ;
            Gx_mode = sMode31 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound31 = 0 ;
            InitializeNonKey0W31( ) ;
            sMode31 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode31 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0W31( ) ;
         if ( RcdFound31 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound31 = 0 ;
         /* Using cursor T000W6 */
         pr_default.execute(4, new Object[] {A31W53POS});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T000W6_A31W53POS[0] < A31W53POS ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T000W6_A31W53POS[0] > A31W53POS ) ) )
            {
               A31W53POS = T000W6_A31W53POS[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31W53POS", StringUtil.LTrim( StringUtil.Str( (decimal)(A31W53POS), 3, 0)));
               RcdFound31 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound31 = 0 ;
         /* Using cursor T000W7 */
         pr_default.execute(5, new Object[] {A31W53POS});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T000W7_A31W53POS[0] > A31W53POS ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T000W7_A31W53POS[0] < A31W53POS ) ) )
            {
               A31W53POS = T000W7_A31W53POS[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31W53POS", StringUtil.LTrim( StringUtil.Str( (decimal)(A31W53POS), 3, 0)));
               RcdFound31 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey0W31( ) ;
         if ( RcdFound31 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "W53POS");
               AnyError = 1 ;
               GX_FocusControl = edtW53POS_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( A31W53POS != Z31W53POS )
            {
               A31W53POS = Z31W53POS ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31W53POS", StringUtil.LTrim( StringUtil.Str( (decimal)(A31W53POS), 3, 0)));
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "CandidateKeyNotFound", 1, "W53POS");
               AnyError = 1 ;
               GX_FocusControl = edtW53POS_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtW53POS_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               /* Update record */
               Update0W31( ) ;
               GX_FocusControl = edtW53POS_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( A31W53POS != Z31W53POS )
            {
               /* Insert record */
               Insert0W31( ) ;
               GX_FocusControl = edtW53POS_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "W53POS");
                  AnyError = 1 ;
                  GX_FocusControl = edtW53POS_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Insert record */
                  Insert0W31( ) ;
                  GX_FocusControl = edtW53POS_Internalname ;
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
         if ( A31W53POS != Z31W53POS )
         {
            A31W53POS = Z31W53POS ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31W53POS", StringUtil.LTrim( StringUtil.Str( (decimal)(A31W53POS), 3, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt"), 1, "W53POS");
            AnyError = 1 ;
            GX_FocusControl = edtW53POS_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtW53POS_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0W31( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000W8 */
            pr_default.execute(6, new Object[] {A31W53POS});
            if ( (pr_default.getStatus(6) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"T53FPOS"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(6) == 101) || ( StringUtil.StrCmp(Z32W53DES, T000W8_A32W53DES[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"T53FPOS"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0W31( )
      {
         BeforeValidate0W31( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0W31( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0W31( 0) ;
            CheckOptimisticConcurrency0W31( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0W31( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0W31( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000W9 */
                     pr_default.execute(7, new Object[] {A31W53POS, A32W53DES});
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
                           ResetCaption0W0( ) ;
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
               Load0W31( ) ;
            }
            EndLevel0W31( ) ;
         }
         CloseExtendedTableCursors0W31( ) ;
      }

      protected void Update0W31( )
      {
         BeforeValidate0W31( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0W31( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0W31( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0W31( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0W31( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000W10 */
                     pr_default.execute(8, new Object[] {A32W53DES, A31W53POS});
                     pr_default.close(8);
                     if ( (pr_default.getStatus(8) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"T53FPOS"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0W31( ) ;
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
            EndLevel0W31( ) ;
         }
         CloseExtendedTableCursors0W31( ) ;
      }

      protected void DeferredUpdate0W31( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0W31( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0W31( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0W31( ) ;
            AfterConfirm0W31( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0W31( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000W11 */
                  pr_default.execute(9, new Object[] {A31W53POS});
                  pr_default.close(9);
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
         sMode31 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0W31( ) ;
         Gx_mode = sMode31 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0W31( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000W12 */
            pr_default.execute(10, new Object[] {A31W53POS});
            if ( (pr_default.getStatus(10) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Maestro de Responsables de Posiciones"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(10);
         }
      }

      protected void EndLevel0W31( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(6);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0W31( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(5);
            pr_default.close(4);
            context.CommitDataStores("TT53FPOS");
            if ( AnyError == 0 )
            {
               ConfirmValues0W0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(5);
            pr_default.close(4);
            context.RollbackDataStores("TT53FPOS");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart0W31( )
      {
         /* Using cursor T000W13 */
         pr_default.execute(11);
         RcdFound31 = 0 ;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound31 = 1 ;
            A31W53POS = T000W13_A31W53POS[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31W53POS", StringUtil.LTrim( StringUtil.Str( (decimal)(A31W53POS), 3, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0W31( )
      {
         pr_default.readNext(11);
         RcdFound31 = 0 ;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound31 = 1 ;
            A31W53POS = T000W13_A31W53POS[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31W53POS", StringUtil.LTrim( StringUtil.Str( (decimal)(A31W53POS), 3, 0)));
         }
      }

      protected void ScanEnd0W31( )
      {
      }

      protected void AfterConfirm0W31( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0W31( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0W31( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0W31( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0W31( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0W31( )
      {
         /* Before Validate Rules */
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0W0( )
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("tt53fpos.aspx") + "?" + UrlEncode("" +AV9W53POS) + "," + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV7SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV8USUARIO))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z31W53POS", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z31W53POS), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z32W53DES", StringUtil.RTrim( Z32W53DES));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vSISTEMA", StringUtil.RTrim( AV7SISTEMA));
         GxWebStd.gx_hidden_field( context, "vUSUARIO", StringUtil.RTrim( AV8USUARIO));
         GxWebStd.gx_hidden_field( context, "vW53POS", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9W53POS), 3, 0, ",", "")));
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
         return "TT53FPOS" ;
      }

      public override String GetPgmdesc( )
      {
         return "Posiciones Sistema Trazabilidad" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("tt53fpos.aspx") + "?" + UrlEncode("" +AV9W53POS) + "," + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV7SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV8USUARIO)) ;
      }

      protected void InitializeNonKey0W31( )
      {
         A32W53DES = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32W53DES", A32W53DES);
      }

      protected void InitAll0W31( )
      {
         A31W53POS = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31W53POS", StringUtil.LTrim( StringUtil.Str( (decimal)(A31W53POS), 3, 0)));
         InitializeNonKey0W31( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Modern.css", "?2051812");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?13224859");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("tt53fpos.js", "?13224859");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         imgBtn_next_separator_Internalname = "BTN_NEXT_SEPARATOR" ;
         imgBtn_select_separator_Internalname = "BTN_SELECT_SEPARATOR" ;
         tblTabletoolbar_Internalname = "TABLETOOLBAR" ;
         lblTextblockw53pos_Internalname = "TEXTBLOCKW53POS" ;
         edtW53POS_Internalname = "W53POS" ;
         lblTextblockw53des_Internalname = "TEXTBLOCKW53DES" ;
         edtW53DES_Internalname = "W53DES" ;
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
         Form.Caption = "Posiciones Sistema Trazabilidad" ;
         imgBtn_select_separator_Visible = 1 ;
         imgBtn_next_separator_Visible = 1 ;
         edtW53DES_Jsonclick = "" ;
         edtW53DES_Enabled = 1 ;
         edtW53POS_Jsonclick = "" ;
         edtW53POS_Enabled = 1 ;
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
         pr_default.close(11);
         pr_default.close(5);
         pr_default.close(4);
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
         lblTextblockw53pos_Jsonclick = "" ;
         lblTextblockw53des_Jsonclick = "" ;
         A32W53DES = "" ;
         imgBtn_next_separator_Jsonclick = "" ;
         imgBtn_select_separator_Jsonclick = "" ;
         Z32W53DES = "" ;
         sMode31 = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         T000W4_A31W53POS = new short[1] ;
         T000W4_A32W53DES = new String[] {""} ;
         T000W5_A31W53POS = new short[1] ;
         T000W3_A31W53POS = new short[1] ;
         T000W3_A32W53DES = new String[] {""} ;
         T000W6_A31W53POS = new short[1] ;
         T000W7_A31W53POS = new short[1] ;
         T000W8_A31W53POS = new short[1] ;
         T000W8_A32W53DES = new String[] {""} ;
         T000W12_A33TTBUS7_Pos = new short[1] ;
         T000W13_A31W53POS = new short[1] ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char3 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tt53fpos__default(),
            new Object[][] {
                new Object[] {
               T000W2_A31W53POS, T000W2_A32W53DES
               }
               , new Object[] {
               T000W3_A31W53POS, T000W3_A32W53DES
               }
               , new Object[] {
               T000W4_A31W53POS, T000W4_A32W53DES
               }
               , new Object[] {
               T000W5_A31W53POS
               }
               , new Object[] {
               T000W6_A31W53POS
               }
               , new Object[] {
               T000W7_A31W53POS
               }
               , new Object[] {
               T000W8_A31W53POS, T000W8_A32W53DES
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000W12_A33TTBUS7_Pos
               }
               , new Object[] {
               T000W13_A31W53POS
               }
            }
         );
      }

      private short wcpOAV9W53POS ;
      private short GxWebError ;
      private short AV9W53POS ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A31W53POS ;
      private short Z31W53POS ;
      private short RcdFound31 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtW53POS_Enabled ;
      private int edtW53DES_Enabled ;
      private int imgBtn_next_separator_Visible ;
      private int imgBtn_select_separator_Visible ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String wcpOAV7SISTEMA ;
      private String wcpOAV8USUARIO ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String AV7SISTEMA ;
      private String AV8USUARIO ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtW53POS_Internalname ;
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
      private String lblTextblockw53pos_Internalname ;
      private String lblTextblockw53pos_Jsonclick ;
      private String edtW53POS_Jsonclick ;
      private String lblTextblockw53des_Internalname ;
      private String lblTextblockw53des_Jsonclick ;
      private String edtW53DES_Internalname ;
      private String A32W53DES ;
      private String edtW53DES_Jsonclick ;
      private String tblTabletoolbar_Internalname ;
      private String imgBtn_next_separator_Internalname ;
      private String imgBtn_next_separator_Jsonclick ;
      private String imgBtn_select_separator_Internalname ;
      private String imgBtn_select_separator_Jsonclick ;
      private String Z32W53DES ;
      private String sMode31 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char3 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private short aP0_W53POS ;
      private String aP1_Gx_mode ;
      private String aP2_SISTEMA ;
      private String aP3_USUARIO ;
      private IDataStoreProvider pr_default ;
      private short[] T000W4_A31W53POS ;
      private String[] T000W4_A32W53DES ;
      private short[] T000W5_A31W53POS ;
      private short[] T000W3_A31W53POS ;
      private String[] T000W3_A32W53DES ;
      private short[] T000W6_A31W53POS ;
      private short[] T000W7_A31W53POS ;
      private short[] T000W8_A31W53POS ;
      private String[] T000W8_A32W53DES ;
      private short[] T000W12_A33TTBUS7_Pos ;
      private short[] T000W13_A31W53POS ;
      private short[] T000W2_A31W53POS ;
      private String[] T000W2_A32W53DES ;
      private GXWebForm Form ;
   }

   public class tt53fpos__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[11])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000W2 ;
          prmT000W2 = new Object[] {
          new Object[] {"@W53POS",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000W4 ;
          prmT000W4 = new Object[] {
          new Object[] {"@W53POS",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000W5 ;
          prmT000W5 = new Object[] {
          new Object[] {"@W53POS",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000W3 ;
          prmT000W3 = new Object[] {
          new Object[] {"@W53POS",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000W6 ;
          prmT000W6 = new Object[] {
          new Object[] {"@W53POS",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000W7 ;
          prmT000W7 = new Object[] {
          new Object[] {"@W53POS",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000W8 ;
          prmT000W8 = new Object[] {
          new Object[] {"@W53POS",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000W9 ;
          prmT000W9 = new Object[] {
          new Object[] {"@W53POS",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@W53DES",SqlDbType.Char,50,0}
          } ;
          Object[] prmT000W10 ;
          prmT000W10 = new Object[] {
          new Object[] {"@W53DES",SqlDbType.Char,50,0} ,
          new Object[] {"@W53POS",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000W11 ;
          prmT000W11 = new Object[] {
          new Object[] {"@W53POS",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000W12 ;
          prmT000W12 = new Object[] {
          new Object[] {"@W53POS",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000W13 ;
          prmT000W13 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T000W2", "SELECT [W53POS], [W53DES] FROM [T53FPOS] WITH (UPDLOCK) WHERE [W53POS] = @W53POS ",true, GxErrorMask.GX_NOMASK, false, this,prmT000W2,1,0,true,false )
             ,new CursorDef("T000W3", "SELECT [W53POS], [W53DES] FROM [T53FPOS] WITH (NOLOCK) WHERE [W53POS] = @W53POS ",true, GxErrorMask.GX_NOMASK, false, this,prmT000W3,1,0,true,false )
             ,new CursorDef("T000W4", "SELECT TM1.[W53POS], TM1.[W53DES] FROM [T53FPOS] TM1 WITH (NOLOCK) WHERE TM1.[W53POS] = @W53POS ORDER BY TM1.[W53POS]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000W4,100,0,true,false )
             ,new CursorDef("T000W5", "SELECT [W53POS] FROM [T53FPOS] WITH (NOLOCK) WHERE [W53POS] = @W53POS  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000W5,1,0,true,false )
             ,new CursorDef("T000W6", "SELECT TOP 1 [W53POS] FROM [T53FPOS] WITH (NOLOCK) WHERE ( [W53POS] > @W53POS) ORDER BY [W53POS]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000W6,1,0,true,true )
             ,new CursorDef("T000W7", "SELECT TOP 1 [W53POS] FROM [T53FPOS] WITH (NOLOCK) WHERE ( [W53POS] < @W53POS) ORDER BY [W53POS] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000W7,1,0,true,true )
             ,new CursorDef("T000W8", "SELECT [W53POS], [W53DES] FROM [T53FPOS] WITH (UPDLOCK) WHERE [W53POS] = @W53POS ",true, GxErrorMask.GX_NOMASK, false, this,prmT000W8,1,0,true,false )
             ,new CursorDef("T000W9", "INSERT INTO [T53FPOS] ([W53POS], [W53DES]) VALUES (@W53POS, @W53DES)", GxErrorMask.GX_NOMASK,prmT000W9)
             ,new CursorDef("T000W10", "UPDATE [T53FPOS] SET [W53DES]=@W53DES  WHERE [W53POS] = @W53POS", GxErrorMask.GX_NOMASK,prmT000W10)
             ,new CursorDef("T000W11", "DELETE FROM [T53FPOS]  WHERE [W53POS] = @W53POS", GxErrorMask.GX_NOMASK,prmT000W11)
             ,new CursorDef("T000W12", "SELECT TOP 1 [TTBUS7_Pos] FROM [TTBUS007] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @W53POS ",true, GxErrorMask.GX_NOMASK, false, this,prmT000W12,1,0,true,true )
             ,new CursorDef("T000W13", "SELECT [W53POS] FROM [T53FPOS] WITH (NOLOCK) ORDER BY [W53POS]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000W13,100,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 10 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 11 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
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
                break;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
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
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
       }
    }

 }

}
