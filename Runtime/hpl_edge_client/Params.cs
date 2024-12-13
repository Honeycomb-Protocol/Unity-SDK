using Newtonsoft.Json;
using System.Collections.Generic;
using HplEdgeClient.Enums;
using HplEdgeClient.Inputs;

namespace HplEdgeClient.Params
{
  public class FindCompressedAccountsParams
  {
    [JsonProperty("addresses")]
    public List<string> Addresses { get; set; }

    [JsonProperty("identity")]
    public DisrcriminatorFilter Identity { get; set; }

    [JsonProperty("leaves")]
    public List<TreeLeaf> Leaves { get; set; }

    [JsonProperty("parsedData")]
    public object ParsedData { get; set; }

    public FindCompressedAccountsParams() { }

  }

  public class FetchProofsParams
  {
    [JsonProperty("leaves")]
    public List<TreeLeaf> Leaves { get; set; }

    public FetchProofsParams() { }

  }

  public class FindAccountsParams
  {
    [JsonProperty("programId")]
    public string ProgramId { get; set; }

    [JsonProperty("discriminator")]
    public string Discriminator { get; set; }

    [JsonProperty("parsedData")]
    public object ParsedData { get; set; }

    public FindAccountsParams() { }

  }

  public class SendTransactionBundlesParams
  {
    [JsonProperty("txs")]
    public List<string> Txs { get; set; }

    [JsonProperty("blockhash")]
    public string Blockhash { get; set; }

    [JsonProperty("lastValidBlockHeight")]
    public int LastValidBlockHeight { get; set; }

    [JsonProperty("options")]
    public SendTransactionBundlesOptions Options { get; set; }

    public SendTransactionBundlesParams() { }

  }

  public class SignWithShadowSignerAndSendTransactionBundlesParams
  {
    [JsonProperty("txs")]
    public List<string> Txs { get; set; }

    [JsonProperty("blockhash")]
    public string Blockhash { get; set; }

    [JsonProperty("lastValidBlockHeight")]
    public int LastValidBlockHeight { get; set; }

    [JsonProperty("authToken")]
    public string AuthToken { get; set; }

    [JsonProperty("options")]
    public SendTransactionBundlesOptions Options { get; set; }

    public SignWithShadowSignerAndSendTransactionBundlesParams() { }

  }

  public class SendBulkTransactionsParams
  {
    [JsonProperty("txs")]
    public List<string> Txs { get; set; }

    [JsonProperty("blockhash")]
    public string Blockhash { get; set; }

    [JsonProperty("lastValidBlockHeight")]
    public int LastValidBlockHeight { get; set; }

    [JsonProperty("options")]
    public SendTransactionBundlesOptions Options { get; set; }

    public SendBulkTransactionsParams() { }

  }

  public class SignWithShadowSignerAndSendBulkTransactionsParams
  {
    [JsonProperty("txs")]
    public List<string> Txs { get; set; }

    [JsonProperty("blockhash")]
    public string Blockhash { get; set; }

    [JsonProperty("lastValidBlockHeight")]
    public int LastValidBlockHeight { get; set; }

    [JsonProperty("options")]
    public SendTransactionBundlesOptions Options { get; set; }

    public SignWithShadowSignerAndSendBulkTransactionsParams() { }

  }

  public class AuthRequestParams
  {
    [JsonProperty("wallet")]
    public string Wallet { get; set; }

    [JsonProperty("useTx")]
    public bool? UseTx { get; set; }

    [JsonProperty("useRpc")]
    public string UseRpc { get; set; }

    public AuthRequestParams() { }

  }

  public class AuthConfirmParams
  {
    [JsonProperty("wallet")]
    public string Wallet { get; set; }

    [JsonProperty("signature")]
    public string Signature { get; set; }

    public AuthConfirmParams() { }

  }

  public class FindGlobalParams
  {
    [JsonProperty("env")]
    public string Env { get; set; }

    public FindGlobalParams() { }

  }

  public class FindProjectsParams
  {
    [JsonProperty("addresses")]
    public List<string> Addresses { get; set; }

    [JsonProperty("names")]
    public List<string> Names { get; set; }

    [JsonProperty("authorities")]
    public List<string> Authorities { get; set; }

    public FindProjectsParams() { }

  }

  public class FindDelegateAuthorityParams
  {
    [JsonProperty("addresses")]
    public List<string> Addresses { get; set; }

    [JsonProperty("delegates")]
    public List<string> Delegates { get; set; }

    [JsonProperty("projects")]
    public List<string> Projects { get; set; }

    public FindDelegateAuthorityParams() { }

  }

  public class FindUsersParams
  {
    [JsonProperty("addresses")]
    public List<string> Addresses { get; set; }

    [JsonProperty("ids")]
    public List<int> Ids { get; set; }

    [JsonProperty("wallets")]
    public List<string> Wallets { get; set; }

    [JsonProperty("includeProof")]
    public bool? IncludeProof { get; set; }

    [JsonProperty("includeProjectProfiles")]
    public List<string> IncludeProjectProfiles { get; set; }

    public FindUsersParams() { }

  }

  public class FindProfilesParams
  {
    [JsonProperty("addresses")]
    public List<string> Addresses { get; set; }

    [JsonProperty("projects")]
    public List<string> Projects { get; set; }

    [JsonProperty("userIds")]
    public List<int> UserIds { get; set; }

    [JsonProperty("identities")]
    public List<string> Identities { get; set; }

    [JsonProperty("includeProof")]
    public bool? IncludeProof { get; set; }

    [JsonProperty("includeUsers")]
    public bool? IncludeUsers { get; set; }

    public FindProfilesParams() { }

  }

  public class CreateNewUserTransactionParams
  {
    [JsonProperty("wallet")]
    public string Wallet { get; set; }

    [JsonProperty("info")]
    public UserInfoInput Info { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateNewUserTransactionParams() { }

  }

  public class CreateNewUserBulkTransactionParams
  {
    [JsonProperty("wallet")]
    public List<string> Wallet { get; set; }

    [JsonProperty("info")]
    public List<UserInfoInput> Info { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateNewUserBulkTransactionParams() { }

  }

  public class CreateUpdateUserTransactionParams
  {
    [JsonProperty("info")]
    public PartialUserInfoInput Info { get; set; }

    [JsonProperty("wallets")]
    public UpdateWalletInput Wallets { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("populateCivic")]
    public bool? PopulateCivic { get; set; }

    [JsonProperty("removeSocials")]
    public List<RemoveSocialsInput> RemoveSocials { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateUpdateUserTransactionParams() { }

  }

  public class CreateCreateProjectTransactionParams
  {
    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("driver")]
    public string Driver { get; set; }

    [JsonProperty("associatedPrograms")]
    public List<AssociatedProgramInput> AssociatedPrograms { get; set; }

    [JsonProperty("profileDataConfig")]
    public ProfileDataConfigInput ProfileDataConfig { get; set; }

    [JsonProperty("subsidizeFees")]
    public bool? SubsidizeFees { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateCreateProjectTransactionParams() { }

  }

  public class CreateChangeProjectDriverTransactionParams
  {
    [JsonProperty("project")]
    public string Project { get; set; }

    [JsonProperty("driver")]
    public string Driver { get; set; }

    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateChangeProjectDriverTransactionParams() { }

  }

  public class CreateCreateDelegateAuthorityTransactionParams
  {
    [JsonProperty("project")]
    public string Project { get; set; }

    [JsonProperty("delegate")]
    public string Delegate { get; set; }

    [JsonProperty("serviceDelegations")]
    public ServiceDelegationInput ServiceDelegations { get; set; }

    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateCreateDelegateAuthorityTransactionParams() { }

  }

  public class CreateModifyDelegationTransactionParams
  {
    [JsonProperty("project")]
    public string Project { get; set; }

    [JsonProperty("delegate")]
    public string Delegate { get; set; }

    [JsonProperty("modifyDelegation")]
    public ModifyDelegationInput ModifyDelegation { get; set; }

    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateModifyDelegationTransactionParams() { }

  }

  public class CreateCreateProfilesTreeTransactionParams
  {
    [JsonProperty("treeConfig")]
    public TreeSetupConfig TreeConfig { get; set; }

    [JsonProperty("project")]
    public string Project { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateCreateProfilesTreeTransactionParams() { }

  }

  public class CreateNewProfileTransactionParams
  {
    [JsonProperty("project")]
    public string Project { get; set; }

    [JsonProperty("identity")]
    public string Identity { get; set; }

    [JsonProperty("info")]
    public ProfileInfoInput Info { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateNewProfileTransactionParams() { }

  }

  public class CreateUpdateProfileTransactionParams
  {
    [JsonProperty("profile")]
    public string Profile { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("info")]
    public ProfileInfoInput Info { get; set; }

    [JsonProperty("customData")]
    public CustomDataInput CustomData { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateUpdateProfileTransactionParams() { }

  }

  public class CreateUpdatePlatformDataTransactionParams
  {
    [JsonProperty("profile")]
    public string Profile { get; set; }

    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("delegateAuthority")]
    public string DelegateAuthority { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("platformData")]
    public PlatformDataInput PlatformData { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateUpdatePlatformDataTransactionParams() { }

  }

  public class CreateNewUserWithProfileTransactionParams
  {
    [JsonProperty("project")]
    public string Project { get; set; }

    [JsonProperty("wallet")]
    public string Wallet { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("userInfo")]
    public UserInfoInput UserInfo { get; set; }

    [JsonProperty("profileIdentity")]
    public string ProfileIdentity { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateNewUserWithProfileTransactionParams() { }

  }

  public class FindAssemblerConfigParams
  {
    [JsonProperty("addresses")]
    public List<string> Addresses { get; set; }

    [JsonProperty("tickers")]
    public List<string> Tickers { get; set; }

    [JsonProperty("characterModel")]
    public List<string> CharacterModel { get; set; }

    [JsonProperty("project")]
    public List<string> Project { get; set; }

    public FindAssemblerConfigParams() { }

  }

  public class FindCharacterTraitsParams
  {
    [JsonProperty("addresses")]
    public List<string> Addresses { get; set; }

    [JsonProperty("trees")]
    public List<string> Trees { get; set; }

    [JsonProperty("includeProof")]
    public bool? IncludeProof { get; set; }

    public FindCharacterTraitsParams() { }

  }

  public class FindCharacterModelsParams
  {
    [JsonProperty("addresses")]
    public List<string> Addresses { get; set; }

    [JsonProperty("project")]
    public string Project { get; set; }

    [JsonProperty("assemblerConfigs")]
    public List<string> AssemblerConfigs { get; set; }

    public FindCharacterModelsParams() { }

  }

  public class FindCharactersParams
  {
    [JsonProperty("includeProof")]
    public bool? IncludeProof { get; set; }

    [JsonProperty("addresses")]
    public List<string> Addresses { get; set; }

    [JsonProperty("filters")]
    public CharactersFilter Filters { get; set; }

    [JsonProperty("trees")]
    public List<string> Trees { get; set; }

    [JsonProperty("wallets")]
    public List<string> Wallets { get; set; }

    [JsonProperty("mints")]
    public List<string> Mints { get; set; }

    [JsonProperty("attributeHashes")]
    public List<string> AttributeHashes { get; set; }

    public FindCharactersParams() { }

  }

  public class FetchCharacterHistoryParams
  {
    [JsonProperty("addresses")]
    public List<string> Addresses { get; set; }

    [JsonProperty("event")]
    public List<string> Event { get; set; }

    public FetchCharacterHistoryParams() { }

  }

  public class CreateCreateAssemblerConfigTransactionParams
  {
    [JsonProperty("treeConfig")]
    public TreeSetupConfig TreeConfig { get; set; }

    [JsonProperty("ticker")]
    public string Ticker { get; set; }

    [JsonProperty("order")]
    public List<string> Order { get; set; }

    [JsonProperty("project")]
    public string Project { get; set; }

    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateCreateAssemblerConfigTransactionParams() { }

  }

  public class CreateAddCharacterTraitsTransactionsParams
  {
    [JsonProperty("assemblerConfig")]
    public string AssemblerConfig { get; set; }

    [JsonProperty("traits")]
    public List<CharacterTraitInput> Traits { get; set; }

    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateAddCharacterTraitsTransactionsParams() { }

  }

  public class CreateRemoveCharacterTraitsTransactionsParams
  {
    [JsonProperty("assemblerConfig")]
    public string AssemblerConfig { get; set; }

    [JsonProperty("traitsAddresses")]
    public List<string> TraitsAddresses { get; set; }

    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateRemoveCharacterTraitsTransactionsParams() { }

  }

  public class CreateCreateCharacterModelTransactionParams
  {
    [JsonProperty("config")]
    public CharacterConfigInput Config { get; set; }

    [JsonProperty("project")]
    public string Project { get; set; }

    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("attributes")]
    public object Attributes { get; set; }

    [JsonProperty("mintAs")]
    public MintAsInput MintAs { get; set; }

    [JsonProperty("cooldown")]
    public CharacterCooldownInput Cooldown { get; set; }

    [JsonProperty("equipableCriteria")]
    public List<string> EquipableCriteria { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateCreateCharacterModelTransactionParams() { }

  }

  public class CreateCreateCharactersTreeTransactionParams
  {
    [JsonProperty("treeConfig")]
    public TreeSetupConfig TreeConfig { get; set; }

    [JsonProperty("project")]
    public string Project { get; set; }

    [JsonProperty("characterModel")]
    public string CharacterModel { get; set; }

    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateCreateCharactersTreeTransactionParams() { }

  }

  public class CreateAssembleCharacterTransactionParams
  {
    [JsonProperty("attributes")]
    public object Attributes { get; set; }

    [JsonProperty("project")]
    public string Project { get; set; }

    [JsonProperty("assemblerConfig")]
    public string AssemblerConfig { get; set; }

    [JsonProperty("characterModel")]
    public string CharacterModel { get; set; }

    [JsonProperty("owner")]
    public string Owner { get; set; }

    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateAssembleCharacterTransactionParams() { }

  }

  public class CreateUpdateCharacterTraitsTransactionParams
  {
    [JsonProperty("characterAddress")]
    public string CharacterAddress { get; set; }

    [JsonProperty("attributes")]
    public object Attributes { get; set; }

    [JsonProperty("project")]
    public string Project { get; set; }

    [JsonProperty("assemblerConfig")]
    public string AssemblerConfig { get; set; }

    [JsonProperty("characterModel")]
    public string CharacterModel { get; set; }

    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateUpdateCharacterTraitsTransactionParams() { }

  }

  public class CreatePopulateCharacterTransactionParams
  {
    [JsonProperty("attributes")]
    public object Attributes { get; set; }

    [JsonProperty("project")]
    public string Project { get; set; }

    [JsonProperty("assemblerConfig")]
    public string AssemblerConfig { get; set; }

    [JsonProperty("characterModel")]
    public string CharacterModel { get; set; }

    [JsonProperty("mint")]
    public string Mint { get; set; }

    [JsonProperty("owner")]
    public string Owner { get; set; }

    [JsonProperty("updateAuthority")]
    public string UpdateAuthority { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreatePopulateCharacterTransactionParams() { }

  }

  public class CreateWrapAssetsToCharacterTransactionsParams
  {
    [JsonProperty("project")]
    public string Project { get; set; }

    [JsonProperty("characterModel")]
    public string CharacterModel { get; set; }

    [JsonProperty("wallet")]
    public string Wallet { get; set; }

    [JsonProperty("mintList")]
    public List<string> MintList { get; set; }

    [JsonProperty("libreplexDeployment")]
    public string LibreplexDeployment { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateWrapAssetsToCharacterTransactionsParams() { }

  }

  public class CreateUnwrapAssetsFromCharacterTransactionsParams
  {
    [JsonProperty("project")]
    public string Project { get; set; }

    [JsonProperty("characterAddresses")]
    public List<string> CharacterAddresses { get; set; }

    [JsonProperty("characterModel")]
    public string CharacterModel { get; set; }

    [JsonProperty("wallet")]
    public string Wallet { get; set; }

    [JsonProperty("libreplexDeployment")]
    public string LibreplexDeployment { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateUnwrapAssetsFromCharacterTransactionsParams() { }

  }

  public class CreateEquipResourceOnCharacterTransactionParams
  {
    [JsonProperty("characterModel")]
    public string CharacterModel { get; set; }

    [JsonProperty("characterAddress")]
    public string CharacterAddress { get; set; }

    [JsonProperty("resource")]
    public string Resource { get; set; }

    [JsonProperty("amount")]
    public string Amount { get; set; }

    [JsonProperty("owner")]
    public string Owner { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateEquipResourceOnCharacterTransactionParams() { }

  }

  public class CreateDismountResourceOnCharacterTransactionParams
  {
    [JsonProperty("characterModel")]
    public string CharacterModel { get; set; }

    [JsonProperty("characterAddress")]
    public string CharacterAddress { get; set; }

    [JsonProperty("resource")]
    public string Resource { get; set; }

    [JsonProperty("amount")]
    public string Amount { get; set; }

    [JsonProperty("owner")]
    public string Owner { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateDismountResourceOnCharacterTransactionParams() { }

  }

  public class FindStakingPoolsParams
  {
    [JsonProperty("addresses")]
    public List<string> Addresses { get; set; }

    [JsonProperty("projects")]
    public List<string> Projects { get; set; }

    [JsonProperty("names")]
    public List<string> Names { get; set; }

    public FindStakingPoolsParams() { }

  }

  public class FindStakersParams
  {
    [JsonProperty("addresses")]
    public List<string> Addresses { get; set; }

    [JsonProperty("stakingPools")]
    public List<string> StakingPools { get; set; }

    [JsonProperty("wallets")]
    public List<string> Wallets { get; set; }

    public FindStakersParams() { }

  }

  public class FindMultipliersParams
  {
    [JsonProperty("addresses")]
    public List<string> Addresses { get; set; }

    [JsonProperty("stakingPools")]
    public List<string> StakingPools { get; set; }

    public FindMultipliersParams() { }

  }

  public class CreateCreateStakingPoolTransactionParams
  {
    [JsonProperty("project")]
    public string Project { get; set; }

    [JsonProperty("resource")]
    public string Resource { get; set; }

    [JsonProperty("metadata")]
    public CreateStakingPoolMetadataInput Metadata { get; set; }

    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("multiplier")]
    public InitStakingMultiplierMetadataInput Multiplier { get; set; }

    [JsonProperty("delegateAuthority")]
    public string DelegateAuthority { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateCreateStakingPoolTransactionParams() { }

  }

  public class CreateUpdateStakingPoolTransactionParams
  {
    [JsonProperty("project")]
    public string Project { get; set; }

    [JsonProperty("stakingPool")]
    public string StakingPool { get; set; }

    [JsonProperty("metadata")]
    public UpdateStakingPoolMetadataInput Metadata { get; set; }

    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("characterModel")]
    public string CharacterModel { get; set; }

    [JsonProperty("resource")]
    public string Resource { get; set; }

    [JsonProperty("delegateAuthority")]
    public string DelegateAuthority { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateUpdateStakingPoolTransactionParams() { }

  }

  public class CreateInitMultipliersTransactionParams
  {
    [JsonProperty("project")]
    public string Project { get; set; }

    [JsonProperty("stakingPool")]
    public string StakingPool { get; set; }

    [JsonProperty("decimals")]
    public int Decimals { get; set; }

    [JsonProperty("multipliers")]
    public List<AddMultiplierMetadataInput> Multipliers { get; set; }

    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("delegateAuthority")]
    public string DelegateAuthority { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateInitMultipliersTransactionParams() { }

  }

  public class CreateAddMultiplierTransactionParams
  {
    [JsonProperty("project")]
    public string Project { get; set; }

    [JsonProperty("multiplier")]
    public string Multiplier { get; set; }

    [JsonProperty("metadata")]
    public AddMultiplierMetadataInput Metadata { get; set; }

    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("delegateAuthority")]
    public string DelegateAuthority { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateAddMultiplierTransactionParams() { }

  }

  public class CreateStakeCharactersTransactionsParams
  {
    [JsonProperty("characterAddresses")]
    public List<string> CharacterAddresses { get; set; }

    [JsonProperty("characterModel")]
    public string CharacterModel { get; set; }

    [JsonProperty("stakingPool")]
    public string StakingPool { get; set; }

    [JsonProperty("project")]
    public string Project { get; set; }

    [JsonProperty("feePayer")]
    public string FeePayer { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateStakeCharactersTransactionsParams() { }

  }

  public class CreateClaimStakingRewardsTransactionsParams
  {
    [JsonProperty("characterAddresses")]
    public List<string> CharacterAddresses { get; set; }

    [JsonProperty("characterModel")]
    public string CharacterModel { get; set; }

    [JsonProperty("feePayer")]
    public string FeePayer { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateClaimStakingRewardsTransactionsParams() { }

  }

  public class CreateUnstakeCharactersTransactionsParams
  {
    [JsonProperty("characterAddresses")]
    public List<string> CharacterAddresses { get; set; }

    [JsonProperty("characterModel")]
    public string CharacterModel { get; set; }

    [JsonProperty("feePayer")]
    public string FeePayer { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateUnstakeCharactersTransactionsParams() { }

  }

  public class FindMissionsParams
  {
    [JsonProperty("addresses")]
    public List<string> Addresses { get; set; }

    [JsonProperty("missionPools")]
    public List<string> MissionPools { get; set; }

    public FindMissionsParams() { }

  }

  public class FindMissionPoolsParams
  {
    [JsonProperty("addresses")]
    public List<string> Addresses { get; set; }

    [JsonProperty("project")]
    public string Project { get; set; }

    public FindMissionPoolsParams() { }

  }

  public class CreateCreateMissionPoolTransactionParams
  {
    [JsonProperty("data")]
    public NewMissionPoolData Data { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateCreateMissionPoolTransactionParams() { }

  }

  public class CreateUpdateMissionPoolTransactionParams
  {
    [JsonProperty("data")]
    public UpdateMissionPoolData Data { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateUpdateMissionPoolTransactionParams() { }

  }

  public class CreateCreateMissionTransactionParams
  {
    [JsonProperty("data")]
    public NewMissionData Data { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateCreateMissionTransactionParams() { }

  }

  public class CreateUpdateMissionTransactionParams
  {
    [JsonProperty("missionAddress")]
    public string MissionAddress { get; set; }

    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("params")]
    public UpdateMissionInput Params { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("delegateAuthority")]
    public string DelegateAuthority { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateUpdateMissionTransactionParams() { }

  }

  public class CreateSendCharactersOnMissionTransactionParams
  {
    [JsonProperty("data")]
    public ParticipateOnMissionData Data { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateSendCharactersOnMissionTransactionParams() { }

  }

  public class CreateRecallCharactersTransactionParams
  {
    [JsonProperty("data")]
    public RecallFromMissionData Data { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateRecallCharactersTransactionParams() { }

  }

  public class FindResourcesParams
  {
    [JsonProperty("addresses")]
    public List<string> Addresses { get; set; }

    [JsonProperty("projects")]
    public List<string> Projects { get; set; }

    [JsonProperty("mints")]
    public List<string> Mints { get; set; }

    public FindResourcesParams() { }

  }

  public class FindResourcesBalanceParams
  {
    [JsonProperty("addresses")]
    public List<string> Addresses { get; set; }

    [JsonProperty("projects")]
    public List<string> Projects { get; set; }

    [JsonProperty("mints")]
    public List<string> Mints { get; set; }

    [JsonProperty("wallets")]
    public List<string> Wallets { get; set; }

    public FindResourcesBalanceParams() { }

  }

  public class FindFaucetsParams
  {
    [JsonProperty("addresses")]
    public List<string> Addresses { get; set; }

    [JsonProperty("projects")]
    public List<string> Projects { get; set; }

    [JsonProperty("resources")]
    public List<string> Resources { get; set; }

    public FindFaucetsParams() { }

  }

  public class FindRecipesParams
  {
    [JsonProperty("addresses")]
    public List<string> Addresses { get; set; }

    [JsonProperty("projects")]
    public List<string> Projects { get; set; }

    public FindRecipesParams() { }

  }

  public class FindHoldingsParams
  {
    [JsonProperty("addresses")]
    public List<string> Addresses { get; set; }

    [JsonProperty("holders")]
    public List<string> Holders { get; set; }

    [JsonProperty("trees")]
    public List<string> Trees { get; set; }

    [JsonProperty("includeProof")]
    public bool? IncludeProof { get; set; }

    public FindHoldingsParams() { }

  }

  public class CreateCreateNewResourceTransactionParams
  {
    [JsonProperty("project")]
    public string Project { get; set; }

    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("params")]
    public InitResourceInput Params { get; set; }

    [JsonProperty("delegateAuthority")]
    public string DelegateAuthority { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateCreateNewResourceTransactionParams() { }

  }

  public class CreateImportFungibleResourceTransactionParams
  {
    [JsonProperty("params")]
    public ImportResourceInput Params { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateImportFungibleResourceTransactionParams() { }

  }

  public class CreateExportFungibleResourceTransactionParams
  {
    [JsonProperty("resource")]
    public string Resource { get; set; }

    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("delegateAuthority")]
    public string DelegateAuthority { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateExportFungibleResourceTransactionParams() { }

  }

  public class CreateCreateNewResourceTreeTransactionParams
  {
    [JsonProperty("project")]
    public string Project { get; set; }

    [JsonProperty("resource")]
    public string Resource { get; set; }

    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("treeConfig")]
    public TreeSetupConfig TreeConfig { get; set; }

    [JsonProperty("delegateAuthority")]
    public string DelegateAuthority { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateCreateNewResourceTreeTransactionParams() { }

  }

  public class CreateMintResourceTransactionParams
  {
    [JsonProperty("resource")]
    public string Resource { get; set; }

    [JsonProperty("owner")]
    public string Owner { get; set; }

    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("amount")]
    public string Amount { get; set; }

    [JsonProperty("delegateAuthority")]
    public string DelegateAuthority { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateMintResourceTransactionParams() { }

  }

  public class CreateBurnResourceTransactionParams
  {
    [JsonProperty("resource")]
    public string Resource { get; set; }

    [JsonProperty("amount")]
    public string Amount { get; set; }

    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("owner")]
    public string Owner { get; set; }

    [JsonProperty("delegateAuthority")]
    public string DelegateAuthority { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateBurnResourceTransactionParams() { }

  }

  public class CreateTransferResourceTransactionParams
  {
    [JsonProperty("resource")]
    public string Resource { get; set; }

    [JsonProperty("owner")]
    public string Owner { get; set; }

    [JsonProperty("recipient")]
    public string Recipient { get; set; }

    [JsonProperty("amount")]
    public string Amount { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateTransferResourceTransactionParams() { }

  }

  public class CreateCreateWrapHoldingTransactionParams
  {
    [JsonProperty("resource")]
    public string Resource { get; set; }

    [JsonProperty("amount")]
    public string Amount { get; set; }

    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateCreateWrapHoldingTransactionParams() { }

  }

  public class CreateCreateUnwrapHoldingTransactionParams
  {
    [JsonProperty("resource")]
    public string Resource { get; set; }

    [JsonProperty("amount")]
    public string Amount { get; set; }

    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateCreateUnwrapHoldingTransactionParams() { }

  }

  public class CreateInitializeFaucetTransactionParams
  {
    [JsonProperty("resource")]
    public string Resource { get; set; }

    [JsonProperty("amount")]
    public int Amount { get; set; }

    [JsonProperty("repeatInterval")]
    public int RepeatInterval { get; set; }

    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("delegateAuthority")]
    public string DelegateAuthority { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateInitializeFaucetTransactionParams() { }

  }

  public class CreateClaimFaucetTransactionParams
  {
    [JsonProperty("faucet")]
    public string Faucet { get; set; }

    [JsonProperty("owner")]
    public string Owner { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateClaimFaucetTransactionParams() { }

  }

  public class CreateInitializeRecipeTransactionParams
  {
    [JsonProperty("project")]
    public string Project { get; set; }

    [JsonProperty("xp")]
    public string Xp { get; set; }

    [JsonProperty("ingredients")]
    public List<IngredientsInput> Ingredients { get; set; }

    [JsonProperty("meal")]
    public MealInput Meal { get; set; }

    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("delegateAuthority")]
    public string DelegateAuthority { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateInitializeRecipeTransactionParams() { }

  }

  public class CreateAddIngredientsTransactionParams
  {
    [JsonProperty("recipe")]
    public string Recipe { get; set; }

    [JsonProperty("ingredients")]
    public List<IngredientsInput> Ingredients { get; set; }

    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("delegateAuthority")]
    public string DelegateAuthority { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateAddIngredientsTransactionParams() { }

  }

  public class CreateRemoveIngredientsTransactionParams
  {
    [JsonProperty("recipe")]
    public string Recipe { get; set; }

    [JsonProperty("ingredients")]
    public List<string> Ingredients { get; set; }

    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("delegateAuthority")]
    public string DelegateAuthority { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateRemoveIngredientsTransactionParams() { }

  }

  public class CreateInitCookingProcessTransactionsParams
  {
    [JsonProperty("recipe")]
    public string Recipe { get; set; }

    [JsonProperty("authority")]
    public string Authority { get; set; }

    [JsonProperty("payer")]
    public string Payer { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    public CreateInitCookingProcessTransactionsParams() { }

  }

  public class CreateInitializeBadgeCriteriaTransactionParams
  {
    [JsonProperty("args")]
    public CreateBadgeCriteriaInput Args { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateInitializeBadgeCriteriaTransactionParams() { }

  }

  public class CreateClaimBadgeCriteriaTransactionParams
  {
    [JsonProperty("args")]
    public ClaimBadgeCriteriaInput Args { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateClaimBadgeCriteriaTransactionParams() { }

  }

  public class CreateUpdateBadgeCriteriaTransactionParams
  {
    [JsonProperty("args")]
    public UpdateBadgeCriteriaInput Args { get; set; }

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses { get; set; }

    [JsonProperty("computeUnitPrice")]
    public int? ComputeUnitPrice { get; set; }

    public CreateUpdateBadgeCriteriaTransactionParams() { }

  }

}

