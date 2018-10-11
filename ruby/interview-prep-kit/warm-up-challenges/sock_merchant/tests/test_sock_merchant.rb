require './lib/sock_merchant.rb'
require 'test/unit'

class TestSockMerchant < Test::Unit::TestCase
  def test_should_return_3
    arr = [10, 20, 20, 10, 10, 30, 50, 10, 20]
    item_count = 9
    expected_matching_pairs = 3
    actual_matching_pairs = Solution.new.sock_merchant(item_count, arr)
    assert_equal(expected_matching_pairs, actual_matching_pairs)
  end

  def test_should_return_4
    arr = [1, 1, 3, 1, 2, 1, 3, 3, 3, 3]
    item_count = 10
    expected_matching_pairs = 4
    actual_matching_pairs = Solution.new.sock_merchant(item_count, arr)
    assert_equal(expected_matching_pairs, actual_matching_pairs)
  end
end
